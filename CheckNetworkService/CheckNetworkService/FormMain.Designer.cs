namespace CheckNetworkService
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_OpenClient = new Button();
            btn_OpenServer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 46);
            label1.TabIndex = 2;
            label1.Text = "CHECK NETWORK SERVICE";
            // 
            // btn_OpenClient
            // 
            btn_OpenClient.BackColor = Color.White;
            btn_OpenClient.FlatStyle = FlatStyle.Flat;
            btn_OpenClient.Location = new Point(137, 66);
            btn_OpenClient.Name = "btn_OpenClient";
            btn_OpenClient.Size = new Size(449, 51);
            btn_OpenClient.TabIndex = 3;
            btn_OpenClient.Text = "Check network service other computer";
            btn_OpenClient.UseVisualStyleBackColor = false;
            btn_OpenClient.Click += btn_OpenClient_Click;
            // 
            // btn_OpenServer
            // 
            btn_OpenServer.BackColor = Color.White;
            btn_OpenServer.FlatStyle = FlatStyle.Flat;
            btn_OpenServer.Location = new Point(137, 123);
            btn_OpenServer.Name = "btn_OpenServer";
            btn_OpenServer.Size = new Size(449, 51);
            btn_OpenServer.TabIndex = 4;
            btn_OpenServer.Text = "Check network service my computer";
            btn_OpenServer.UseVisualStyleBackColor = false;
            btn_OpenServer.Click += btn_OpenServer_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 201);
            Controls.Add(btn_OpenServer);
            Controls.Add(btn_OpenClient);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Check Service App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_OpenClient;
        private Button btn_OpenServer;
    }
}
