namespace App_LoadBalancer
{
    partial class FormSetting
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
            listView_Deltail_Server = new ListView();
            panel_add = new Panel();
            txt_url = new TextBox();
            lb_message = new Label();
            btn_connect = new Button();
            btn_Delete = new Button();
            panel_add.SuspendLayout();
            SuspendLayout();
            // 
            // listView_Deltail_Server
            // 
            listView_Deltail_Server.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_Deltail_Server.CheckBoxes = true;
            listView_Deltail_Server.Location = new Point(12, 12);
            listView_Deltail_Server.Name = "listView_Deltail_Server";
            listView_Deltail_Server.Size = new Size(776, 225);
            listView_Deltail_Server.TabIndex = 0;
            listView_Deltail_Server.UseCompatibleStateImageBehavior = false;
            listView_Deltail_Server.View = View.Details;
            listView_Deltail_Server.ItemCheck += listView_Deltail_Server_ItemCheck;
            // 
            // panel_add
            // 
            panel_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_add.Controls.Add(txt_url);
            panel_add.Controls.Add(lb_message);
            panel_add.Controls.Add(btn_connect);
            panel_add.Location = new Point(-4, 243);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(517, 211);
            panel_add.TabIndex = 2;
            // 
            // txt_url
            // 
            txt_url.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_url.Location = new Point(16, 0);
            txt_url.Multiline = true;
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(353, 46);
            txt_url.TabIndex = 4;
            // 
            // lb_message
            // 
            lb_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_message.AutoSize = true;
            lb_message.Location = new Point(16, 49);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(0, 20);
            lb_message.TabIndex = 3;
            // 
            // btn_connect
            // 
            btn_connect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_connect.BackColor = Color.White;
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_connect.Location = new Point(375, 0);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(142, 46);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Delete.BackColor = Color.White;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.Location = new Point(616, 243);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(172, 46);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Visible = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(btn_Delete);
            Controls.Add(panel_add);
            Controls.Add(listView_Deltail_Server);
            Name = "FormSetting";
            Text = "FormSetting";
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_Deltail_Server;
        private Panel panel_add;
        private Button btn_connect;
        private Label lb_message;
        private TextBox txt_url;
        private Button btn_Delete;
    }
}