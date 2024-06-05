namespace CheckNetworkService
{
    partial class CheckNetworkServiceServer
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
            richTextBoxInfo = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(12, 90);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Size = new Size(692, 514);
            richTextBoxInfo.TabIndex = 0;
            richTextBoxInfo.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(449, 46);
            label1.TabIndex = 1;
            label1.Text = "CHECK NETWORK SERVICE";
            // 
            // CheckNetworkServiceServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 670);
            Controls.Add(label1);
            Controls.Add(richTextBoxInfo);
            Name = "CheckNetworkServiceServer";
            Text = "CheckNetworkServiceServer";
            Load += CheckNetworkServiceServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxInfo;
        private Label label1;
    }
}