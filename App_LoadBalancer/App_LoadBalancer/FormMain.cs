namespace App_LoadBalancer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Khai báo
        private Form currentFormChild;

        //Các hàm thao tác
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_DisplayForm.Controls.Add(childForm);
            panel_DisplayForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStatus());
        }

        public void btn_Setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetting());   
        }
    }
}
