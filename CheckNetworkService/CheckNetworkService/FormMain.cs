using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Management;
using System.ServiceProcess;
using System;

namespace CheckNetworkService
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void btn_OpenClient_Click(object sender, EventArgs e)
        {
            OpenForm(new CheckNetworkServiceClient());
        }

        private void btn_OpenServer_Click(object sender, EventArgs e)
        {
            OpenForm(new CheckNetworkServiceServer());
        }
    }
}
