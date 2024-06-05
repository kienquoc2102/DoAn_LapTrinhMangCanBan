namespace CheckNetworkService
{
    partial class CheckNetworkServiceClient
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
            label1 = new Label();
            label2 = new Label();
            txt_ip = new TextBox();
            richTextBoxInfo = new RichTextBox();
            label3 = new Label();
            btn_Connect = new Button();
            btn_Check = new Button();
            btn_Disconnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 0;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(137, 9);
            label2.Name = "label2";
            label2.Size = new Size(449, 46);
            label2.TabIndex = 3;
            label2.Text = "CHECK NETWORK SERVICE";
            // 
            // txt_ip
            // 
            txt_ip.Location = new Point(108, 65);
            txt_ip.Name = "txt_ip";
            txt_ip.Size = new Size(609, 27);
            txt_ip.TabIndex = 4;
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(12, 143);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Size = new Size(705, 491);
            richTextBoxInfo.TabIndex = 5;
            richTextBoxInfo.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.White;
            btn_Connect.FlatStyle = FlatStyle.Flat;
            btn_Connect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Connect.Location = new Point(592, 640);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(125, 45);
            btn_Connect.TabIndex = 7;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Check
            // 
            btn_Check.BackColor = Color.White;
            btn_Check.FlatStyle = FlatStyle.Flat;
            btn_Check.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Check.Location = new Point(12, 640);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(142, 45);
            btn_Check.TabIndex = 8;
            btn_Check.Text = "Check services";
            btn_Check.UseVisualStyleBackColor = false;
            btn_Check.Click += btn_Check_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.BackColor = Color.White;
            btn_Disconnect.FlatStyle = FlatStyle.Flat;
            btn_Disconnect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Disconnect.Location = new Point(461, 640);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(125, 45);
            btn_Disconnect.TabIndex = 9;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = false;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // CheckNetworkServiceClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 697);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Check);
            Controls.Add(btn_Connect);
            Controls.Add(label3);
            Controls.Add(richTextBoxInfo);
            Controls.Add(txt_ip);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckNetworkServiceClient";
            Text = "CheckNetworkServiceClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_ip;
        private RichTextBox richTextBoxInfo;
        private Label label3;
        private Button btn_Connect;
        private Button btn_Check;
        private Button btn_Disconnect;
    }
}