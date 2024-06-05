using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CheckNetworkService
{
    public partial class CheckNetworkServiceClient : Form
    {
        public CheckNetworkServiceClient()
        {
            InitializeComponent();
        }

        private TcpClient client;
        private delegate void infoDelegate(string info);

        private void DisplayInfo(string info)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                var invoke = new infoDelegate(DisplayInfo);
                richTextBoxInfo.Invoke(invoke, new object[] { info });
            }
            else
            {
                richTextBoxInfo.Text = null;
                richTextBoxInfo.Text = info;
            }
        }

        private void Connect()
        {
            try
            {
                client = new TcpClient(txt_ip.Text, 8888);
                MessageBox.Show($"Connected to {txt_ip.Text}.");
                label3.Visible = true;
                label3.Text = $"Connected to {txt_ip.Text}.";
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void Disconnect()
        {
            client.Close();
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
        }

        private void CheckServices()
        {
            try
            {
                NetworkStream stream = client.GetStream();

                // Send request to server
                byte[] request = Encoding.ASCII.GetBytes("CHECK_SERVICES");
                stream.Write(request, 0, request.Length);

                // Read response from server
                StringBuilder responseBuilder = new StringBuilder();
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string responseChunk = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (responseChunk.Contains("<END_OF_MESSAGE>"))
                    {
                        responseBuilder.Append(responseChunk.Replace("<END_OF_MESSAGE>", ""));
                        break;
                    }
                    responseBuilder.Append(responseChunk);
                }

                // Display the complete response
                string response = responseBuilder.ToString();
                DisplayInfo(response);

                label3.Text = $"Check services on {txt_ip.Text}";
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking services: " + ex.Message);
            }
        }


        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            CheckServices();
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
