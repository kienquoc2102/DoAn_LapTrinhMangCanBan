using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CheckNetworkService
{
    public partial class CheckNetworkServiceServer : Form
    {
        public CheckNetworkServiceServer()
        {
            InitializeComponent();
        }

        private TcpListener server;
        private Thread listenerThread;

        //Hiển thị thông tin mạng của máy tính
        private void DisplayInfo()
        {
            richTextBoxInfo.Text += GetService();
            richTextBoxInfo.Text += GetConnections();
        }

        //Lấy các dịch vụ mạng bằng cách sử dụng WMI
        private string GetService()
        {
            // Get services
            string service_info = "";
            string query = "SELECT * FROM Win32_Service WHERE Started = true";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection services = searcher.Get();

            foreach (ManagementObject service in services)
            {
                string name = service["Name"].ToString();
                string displayName = service["DisplayName"].ToString();
                string state = service["State"].ToString();
                string startMode = service["StartMode"].ToString();

                service_info += $"Service Name: {name}\n" +
                        $"- Display Name: {displayName}\n" +
                        $"- State: {state}\n" +
                        $"- Start Mode: {startMode}\n";
            }
            return service_info;
        }

        //Lấy các kết nối bằng netstat
        private string GetConnections()
        {
            ProcessStartInfo psi = new ProcessStartInfo("netstat", "-an")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process process = Process.Start(psi);
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        private void ResponseCheck()
        {
            server = new TcpListener(IPAddress.Any, 8888);
            listenerThread = new Thread(new ThreadStart(StartListening));
            listenerThread.Start();
        }

        private void StartListening()
        {
            server.Start();
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                // Read data from client
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string request = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (request == "CHECK_SERVICES")
                {
                    string servicesList = GetService() + "\n" + GetConnections();
                    byte[] response = Encoding.ASCII.GetBytes(servicesList);

                    // Send data in chunks
                    int chunkSize = 1024;
                    for (int i = 0; i < response.Length; i += chunkSize)
                    {
                        int size = Math.Min(chunkSize, response.Length - i);
                        stream.Write(response, i, size);
                    }

                    // Indicate end of message
                    byte[] endMessage = Encoding.ASCII.GetBytes("<END_OF_MESSAGE>");
                    stream.Write(endMessage, 0, endMessage.Length);
                }

                client.Close();
            }
        }


        private void CheckNetworkServiceServer_Load(object sender, EventArgs e)
        {
            DisplayInfo();
            ResponseCheck();
        }

        
    }
}
