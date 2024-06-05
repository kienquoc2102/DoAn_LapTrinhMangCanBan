using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace App_LoadBalancer
{
    public class WebProxy
    {
        public Socket clientSocket;
        public FormStatus UserInterface;

        public void run()
        {
            string sURL = UserInterface.GetMirror();
            byte[] readln = new byte[1024];
            int bytes = clientSocket.Receive(readln);
            string clientmessage = Encoding.ASCII.GetString(readln);
            //Xem request
            if (clientmessage.Contains("GET"))
            {
                UserInterface.reportMessage("New Client \r\n");
                UserInterface.reportMessage(clientmessage + "\r\n");
                clientmessage = clientmessage.Substring(0, bytes);
                int posHost = clientmessage.IndexOf("Host:");
                int posEndOfLine = clientmessage.IndexOf("\r\n", posHost);
                clientmessage = clientmessage.Remove(posHost, posEndOfLine - posHost);
                clientmessage = clientmessage.Insert(posHost, "Host:" + sURL);
                readln = Encoding.ASCII.GetBytes(clientmessage);
                if (bytes == 0) { return; }
                UserInterface.reportMessage("Connect from: " + clientSocket.RemoteEndPoint + "\r\n");
                UserInterface.reportMessage("Connect to Site: " + sURL + "\r\n");
                relayTCP(sURL, 80, clientmessage);
            }    
            else
            {
                UserInterface.reportMessage("Connect from: " + clientSocket.RemoteEndPoint + "\r\n");
                UserInterface.reportMessage("Connect to Site: " + sURL + "\r\n");
            }    
            clientSocket.Close();
        }

        public void relayTCP(string host, int port, string cmd)
        {
            byte[] szData;
            byte[] RecvBytes = new byte[Byte.MaxValue];
            Int32 bytes;
            TcpClient TcpClientSocket = new TcpClient(host, port);
            NetworkStream NetStrm = TcpClientSocket.GetStream();
            szData = System.Text.Encoding.ASCII.GetBytes(cmd.ToCharArray());
            NetStrm.Write(szData, 0, szData.Length);

            while (true)
            {
                try
                {
                    bytes = NetStrm.Read(RecvBytes, 0, RecvBytes.Length);
                    clientSocket.Send(RecvBytes, bytes, SocketFlags.None);
                    if (bytes <= 0)
                        break;
                }
                catch
                {
                    UserInterface.reportMessage("Fail Connect");
                    break;
                }
            }
        }
    }
}
