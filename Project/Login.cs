using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        List<Admin> admins = new List<Admin>() { new Admin() { UserName = "admin1" , Password ="123"} };
        public Login()
        {
            InitializeComponent();
        }
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            SetForm();
        }

        private void Login_Move(object sender, EventArgs e)
        {
            SetForm();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            foreach (Admin item in admins)
            {
                if ((TxtUser.Text == item.UserName) && (Textpass.Text == item.Password))
                {
                    MainForm mainForm = new MainForm(this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Name Or Password Is Error...");
                }
            }
              
        }
        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void SetForm()
        {
            this.Size = new Size(1000, 500);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
    }
}
