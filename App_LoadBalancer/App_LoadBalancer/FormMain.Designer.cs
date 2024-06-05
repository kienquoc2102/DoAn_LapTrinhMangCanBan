namespace App_LoadBalancer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel_Menu = new Panel();
            btn_Setting = new Button();
            btn_Status = new Button();
            btn_rSizeMenu = new Button();
            panel_Title = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel_DisplayForm = new Panel();
            panel_Menu.SuspendLayout();
            panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = SystemColors.ControlDark;
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Controls.Add(btn_Setting);
            panel_Menu.Controls.Add(btn_Status);
            panel_Menu.Controls.Add(btn_rSizeMenu);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(143, 856);
            panel_Menu.TabIndex = 0;
            // 
            // btn_Setting
            // 
            btn_Setting.BackColor = SystemColors.ControlDark;
            btn_Setting.FlatAppearance.BorderSize = 0;
            btn_Setting.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            btn_Setting.FlatStyle = FlatStyle.Flat;
            btn_Setting.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Setting.Image = (Image)resources.GetObject("btn_Setting.Image");
            btn_Setting.Location = new Point(-1, 228);
            btn_Setting.Name = "btn_Setting";
            btn_Setting.Size = new Size(141, 70);
            btn_Setting.TabIndex = 2;
            btn_Setting.Text = "Setting     ";
            btn_Setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Setting.UseVisualStyleBackColor = false;
            btn_Setting.Click += btn_Setting_Click;
            // 
            // btn_Status
            // 
            btn_Status.BackColor = SystemColors.ControlDark;
            btn_Status.FlatAppearance.BorderSize = 0;
            btn_Status.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            btn_Status.FlatStyle = FlatStyle.Flat;
            btn_Status.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Status.Image = (Image)resources.GetObject("btn_Status.Image");
            btn_Status.Location = new Point(0, 152);
            btn_Status.Name = "btn_Status";
            btn_Status.Size = new Size(142, 70);
            btn_Status.TabIndex = 1;
            btn_Status.Text = "Status       ";
            btn_Status.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Status.UseVisualStyleBackColor = false;
            btn_Status.Click += btn_Status_Click;
            // 
            // btn_rSizeMenu
            // 
            btn_rSizeMenu.BackColor = SystemColors.ControlDark;
            btn_rSizeMenu.FlatAppearance.BorderSize = 0;
            btn_rSizeMenu.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            btn_rSizeMenu.FlatStyle = FlatStyle.Flat;
            btn_rSizeMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_rSizeMenu.Image = (Image)resources.GetObject("btn_rSizeMenu.Image");
            btn_rSizeMenu.Location = new Point(0, 76);
            btn_rSizeMenu.Name = "btn_rSizeMenu";
            btn_rSizeMenu.Size = new Size(140, 70);
            btn_rSizeMenu.TabIndex = 0;
            btn_rSizeMenu.Text = "Home        ";
            btn_rSizeMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_rSizeMenu.UseVisualStyleBackColor = false;
            // 
            // panel_Title
            // 
            panel_Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Title.BackColor = Color.White;
            panel_Title.BorderStyle = BorderStyle.FixedSingle;
            panel_Title.Controls.Add(pictureBox1);
            panel_Title.Controls.Add(label1);
            panel_Title.Location = new Point(1, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(1124, 71);
            panel_Title.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 11);
            label1.Name = "label1";
            label1.Size = new Size(245, 34);
            label1.TabIndex = 0;
            label1.Text = "LOAD BALANCER";
            // 
            // panel_DisplayForm
            // 
            panel_DisplayForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_DisplayForm.BackColor = Color.White;
            panel_DisplayForm.BorderStyle = BorderStyle.FixedSingle;
            panel_DisplayForm.Location = new Point(141, 77);
            panel_DisplayForm.Name = "panel_DisplayForm";
            panel_DisplayForm.Size = new Size(984, 779);
            panel_DisplayForm.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1125, 856);
            Controls.Add(panel_DisplayForm);
            Controls.Add(panel_Title);
            Controls.Add(panel_Menu);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Load Balancer";
            panel_Menu.ResumeLayout(false);
            panel_Title.ResumeLayout(false);
            panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Menu;
        private Panel panel_Title;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_rSizeMenu;
        private Button btn_Setting;
        private Button btn_Status;
        private Panel panel_DisplayForm;
    }
}
