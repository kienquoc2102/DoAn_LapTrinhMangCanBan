using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_LoadBalancer
{
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
            LoadServers();
            LoadListViewServer();
            CheckServerConnect();   
        }

        //I. Khai báo
        public int port;
        public int site;
        public TcpListener tcplistener;
        private delegate void InfoMessageDel(string message);
        private delegate void ActiveServer(string server);
        private delegate void InactiveServer(string server);
        private readonly object siteLock = new object();
        private List<string> servers = new List<string>();
        private List<string> active_servers = new List<string>();
        private readonly object reportLock = new object();

        //II. Kết nối
        //Kiểm tra kết nối đến các Server
        private void CheckServerConnect()
        {
            foreach (string server in servers)
            {
                try
                {
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        tcpClient.Connect(server, 80);
                        DisplayActive(server);
                        active_servers.Add(server);
                    }
                }
                catch (Exception ex)
                {
                    DisplayInactive(server);
                }
            }
        }


        //Khi bấm Run, chờ đợi vô hạn chờ các kết nối TCP từ bên ngoài
        private void btn_Run_Click(object sender, EventArgs e)
        {
            btn_Run.Enabled = false;
            Thread thread = new Thread(new ThreadStart(ListenerThread));
            thread.Start();
        }

        //Thực hiện lắng nghe trên port 8889 và chờ kết nối
        public void ListenerThread()
        {
            site = 0;
            port = 9009;
            tcplistener = new TcpListener(IPAddress.Any, port);
            reportMessage("Listening on port " + port);
            tcplistener.Start();
            while (true)
            {
                try
                {
                    CheckServerConnect();
                    Socket clientSocket = tcplistener.AcceptSocket();

                    WebProxy webproxy = new WebProxy();
                    webproxy.UserInterface = this;
                    webproxy.clientSocket = clientSocket;
                    Thread thread = new Thread(new ThreadStart(webproxy.run));
                    thread.Start();
                }
                catch
                {

                }
            }
        }

        //Thuật toán RoundRobin
        public string GetMirror()
        {
            lock (siteLock)
            {
                string Mirror = active_servers[site];
                site = (site + 1) % active_servers.Count;
                return Mirror;
            }
        }

        //Hàm dừng lắng nghe kết nối
        private void StopListen()
        {
            tcplistener.Stop();
            btn_Run.Enabled = true;
        }

        //III. Hiển thị
        //Hiển thị các thông báo kết nối từ Client
        public void reportMessage(string message)
        {
            lock (this)
            {
                string s = message + "\r\n";
                InfoMessage(s);
            }
        }

        public void InfoMessage(string info)
        {
            if (listBox_Clients.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                listBox_Clients.Invoke(method, new object[] { info });
                return;
            }
            listBox_Clients.Items.Add(info);
        }

        //Hiển thị trạng thái của các Server
        public void LoadListViewServer()
        {
            listView_Servers.View = View.Details;
            listView_Servers.GridLines = true;
            listView_Servers.Columns.Add("Server");
            listView_Servers.Columns.Add("State");
            listView_Servers.Columns[0].Width = -2;
            listView_Servers.Columns[1].Width = -2;
        }
        public void DisplayActive(string server)
        {
            if (listView_Servers.InvokeRequired)
            {
                ActiveServer invoke = new ActiveServer(DisplayActive);
                listView_Servers.Invoke(invoke, new object[] { server });
            }
            else
            {
                UpdateServerStatus(server, "Active", 0);
            }
        }

        public void DisplayInactive(string server)
        {
            if (listView_Servers.InvokeRequired)
            {
                ActiveServer invoke = new ActiveServer(DisplayActive);
                listView_Servers.Invoke(invoke, new object[] { server });
            }
            else
            {
                UpdateServerStatus(server, "Inactive", 1);
            }
        }

        private void UpdateServerStatus(string server, string status, int state)
        {
            ListViewItem existingItem = listView_Servers.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Text == server);
            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = status;
            }
            else
            {
                ListViewItem newItem = new ListViewItem(server);
                if (state == 0)
                    newItem.ForeColor = Color.Green;
                else
                    newItem.ForeColor = Color.Red;
                newItem.SubItems.Add(status);
                listView_Servers.Items.Add(newItem);
            }
            listView_Servers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //IV. Thao tác
        public List<string> GetServers()
        {
            LoadServers();
            return servers;
        }

        public void AddServer(string url)
        {
            servers.Add(url);
        }

        //V. Lấy danh sách Server từ một file ghi nhớ Server
        private List<string> GetServerList()
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader("Servers.txt"))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public void LoadServers()
        {
            servers = GetServerList();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            StopListen();
        }

        private void FormStatus_Leave(object sender, EventArgs e)
        {
            StopListen();
        }
    }
}
