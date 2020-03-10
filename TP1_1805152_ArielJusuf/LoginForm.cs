using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_1805152_ArielJusuf
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get username and password dari textbox
            string username = Convert.ToString(usernameBox.Text);
            string password = Convert.ToString(passwordBox.Text);

            // Verifikasi Password
            if(string.Compare(password, "pbo123") == 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                usernameBox.Text = null;
                passwordBox.Text = null;
                wrongPassLabel.Text = "Password Salah!";
            }
        }
    }
}
