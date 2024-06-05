namespace App_LoadBalancer
{
    partial class FormStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Servers = new Panel();
            listView_Servers = new ListView();
            label1 = new Label();
            panel_Clients = new Panel();
            listBox_Clients = new ListBox();
            label2 = new Label();
            btn_Stop = new Button();
            btn_Run = new Button();
            panel_Servers.SuspendLayout();
            panel_Clients.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Servers
            // 
            panel_Servers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Servers.BackColor = Color.White;
            panel_Servers.BorderStyle = BorderStyle.FixedSingle;
            panel_Servers.Controls.Add(listView_Servers);
            panel_Servers.Controls.Add(label1);
            panel_Servers.Location = new Point(12, 12);
            panel_Servers.Name = "panel_Servers";
            panel_Servers.Size = new Size(776, 179);
            panel_Servers.TabIndex = 0;
            // 
            // listView_Servers
            // 
            listView_Servers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView_Servers.Location = new Point(12, 36);
            listView_Servers.Name = "listView_Servers";
            listView_Servers.Size = new Size(747, 124);
            listView_Servers.TabIndex = 1;
            listView_Servers.UseCompatibleStateImageBehavior = false;
            listView_Servers.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Active Servers";
            // 
            // panel_Clients
            // 
            panel_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Clients.BackColor = Color.White;
            panel_Clients.BorderStyle = BorderStyle.FixedSingle;
            panel_Clients.Controls.Add(listBox_Clients);
            panel_Clients.Controls.Add(label2);
            panel_Clients.Location = new Point(12, 197);
            panel_Clients.Name = "panel_Clients";
            panel_Clients.Size = new Size(776, 332);
            panel_Clients.TabIndex = 1;
            // 
            // listBox_Clients
            // 
            listBox_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_Clients.FormattingEnabled = true;
            listBox_Clients.Location = new Point(12, 49);
            listBox_Clients.Name = "listBox_Clients";
            listBox_Clients.Size = new Size(747, 244);
            listBox_Clients.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Connected Clients";
            // 
            // btn_Stop
            // 
            btn_Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Stop.BackColor = Color.White;
            btn_Stop.FlatAppearance.BorderSize = 2;
            btn_Stop.FlatStyle = FlatStyle.Flat;
            btn_Stop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Stop.Location = new Point(645, 535);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(143, 37);
            btn_Stop.TabIndex = 2;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = false;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // btn_Run
            // 
            btn_Run.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Run.BackColor = Color.White;
            btn_Run.FlatAppearance.BorderSize = 2;
            btn_Run.FlatStyle = FlatStyle.Flat;
            btn_Run.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Run.Location = new Point(487, 535);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(143, 37);
            btn_Run.TabIndex = 3;
            btn_Run.Text = "Run";
            btn_Run.UseVisualStyleBackColor = false;
            btn_Run.Click += btn_Run_Click;
            // 
            // FormStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(btn_Run);
            Controls.Add(btn_Stop);
            Controls.Add(panel_Clients);
            Controls.Add(panel_Servers);
            Name = "FormStatus";
            Text = "FormStatus";
            Leave += FormStatus_Leave;
            panel_Servers.ResumeLayout(false);
            panel_Servers.PerformLayout();
            panel_Clients.ResumeLayout(false);
            panel_Clients.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Servers;
        private ListView listView_Servers;
        private Label label1;
        private Panel panel_Clients;
        private Label label2;
        private Button btn_Stop;
        private Button btn_Run;
        private ListBox listBox_Clients;
    }
}