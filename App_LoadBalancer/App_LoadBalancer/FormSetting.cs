using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App_LoadBalancer.FormStatus;

namespace App_LoadBalancer
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            //LoadServerList();
            LoadListViewServer();
            CheckServerConnect();
        }

        //I. Khai báo
        FormStatus formStatus = new FormStatus();
        private delegate void announcement(int set);
        List<string> servers = new List<string>();
        List<string> deleted_servers = new List<string>();
        private delegate void ActiveServer(string server, TimeSpan time);
        private delegate void InactiveServer(string server, TimeSpan time);

        //II. Kết nối
        //Kiểm tra kết nối đến các Server
        private void CheckServerConnect()
        {
            LoadServerList();
            foreach (string server in servers)
            {
                try
                {
                    //Bắt đầu đo thời gian 
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        tcpClient.Connect(server, 80);
                        
                    }

                    //Dừng thời gian
                    stopwatch.Stop();
                    TimeSpan responsetime  = stopwatch.Elapsed;
                    DisplayActive(server, responsetime);
                }
                catch (Exception ex)
                {
                    TimeSpan responsetime = TimeSpan.Zero;
                    DisplayInactive(server, responsetime);
                }
            }
        }

        //Kết nối đến Server, nết thành công thì thêm vào, không thì thông cáo kết nối thất bại
        private void TryConnect()
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect(txt_url.Text, 80);
                    servers.Add(txt_url.Text);
                    WriteServers();
                    AnnounceConnect(0);
                    CheckServerConnect();
                }
            }
            catch
            {
                AnnounceConnect(1);
            }
        }

        //III. Hiển thị
        //Load Server List
        private void LoadServerList()
        {
            servers = formStatus.GetServers();
        }

        //Hiển thị trạng thái của các Server
        public void LoadListViewServer()
        {
            listView_Deltail_Server.View = View.Details;
            listView_Deltail_Server.GridLines = true;
            listView_Deltail_Server.Columns.Add("Server");
            listView_Deltail_Server.Columns.Add("State");
            listView_Deltail_Server.Columns.Add("Response Time");
            listView_Deltail_Server.Columns[0].Width = -2;
            listView_Deltail_Server.Columns[1].Width = -2;
        }
        //Hiển thị Server hoạt động
        public void DisplayActive(string server, TimeSpan time)
        {
            if (listView_Deltail_Server.InvokeRequired)
            {
                ActiveServer invoke = new ActiveServer(DisplayActive);
                listView_Deltail_Server.Invoke(invoke, new object[] { server });
            }
            else
            {
                UpdateServerStatus(server, "Active", time, 0);
            }
        }

        //Hiển thị Server không hoạt động
        public void DisplayInactive(string server, TimeSpan time)
        {
            if (listView_Deltail_Server.InvokeRequired)
            {
                InactiveServer invoke = new InactiveServer(DisplayActive);
                listView_Deltail_Server.Invoke(invoke, new object[] { server });
            }
            else
            {
                UpdateServerStatus(server, "Inactive", time,1);
            }
        }

        private void UpdateServerStatus(string server, string status, TimeSpan time, int state)
        {
            ListViewItem existingItem = listView_Deltail_Server.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Text == server);
            if (existingItem != null)
            {
                existingItem.SubItems[1].Text = status;
                existingItem.SubItems[2].Text = time.ToString();
            }
            else
            {
                ListViewItem newItem = new ListViewItem(server);
                if (state == 0)
                    newItem.ForeColor = Color.Green;
                else if (state == 1)
                    newItem.ForeColor = Color.Red;
                newItem.SubItems.Add(status);
                newItem.SubItems.Add(time.ToString());
                listView_Deltail_Server.Items.Add(newItem);
            }
            listView_Deltail_Server.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //Thông báo kết nối có thành công hay không
        private void AnnounceConnect(int set)
        {
            if (lb_message.InvokeRequired)
            {
                announcement invoke = new announcement(AnnounceConnect);
                lb_message.Invoke(invoke);
            }
            else
            {
                if (set == 0)
                {
                    lb_message.Text = "Successful connection!";
                    lb_message.ForeColor = Color.Green;
                }
                else
                {
                    lb_message.Text = $"{txt_url.Text} not found or not working!";
                    lb_message.ForeColor = Color.Red;
                }
            }
        }

        //IV. Thao tác
        //Ghi danh sách server vào file Servers
        public void WriteServers()
        {
            try
            {
                using (StreamWriter wr = new StreamWriter("Servers.txt"))
                {
                    foreach (string server in servers)
                    {
                        wr.WriteLine(server);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Hàm lấy các Server được chọn
        private List<string> SelectedServer(ListView listView)
        {
            List<String> selectedItems = new List<string>();
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Checked)
                {
                    selectedItems.Add(item.Text);
                }
            }
            return selectedItems;
        }

        //Hàm xóa Server
        private void Delete()
        {
            deleted_servers = SelectedServer(listView_Deltail_Server);
            foreach (string item in deleted_servers)
            {
                servers.Remove(item);
            }
            WriteServers();
            CheckServerConnect();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            TryConnect();
            txt_url.Text = null;
        }

        private void listView_Deltail_Server_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListView listView = sender as ListView;

            if (listView == null)
            {
                return;
            }

            bool isChecked = (e.NewValue == CheckState.Checked);

            int checkedItemCount = listView.CheckedItems.Count + (isChecked ? 1 : -1);

            btn_Delete.Visible = checkedItemCount > 0;
            panel_add.Visible = checkedItemCount == 0;
        }

    }
}
