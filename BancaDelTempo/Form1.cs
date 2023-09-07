using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaDelTempo
{
    public partial class FormLogin : Form
    {
        string username;
        string password;

        bool passwordShown = false;

        bool isLoggedIn=false;

        string hours_minutes = DateTime.Now.ToString("HH : mm");
        public FormLogin()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"files\user.txt");
            username = sr.ReadLine();
            password = sr.ReadLine();
            sr.Close();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
            //////////////////////////////////
            this.Hide();
            FormMain f = new FormMain();
            f.ShowDialog();
        }

        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm");
        }

        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            if (passwordShown == false)
            {
                showPassword();
                return;
            }
            else if(passwordShown == true)
            {
                hidePassword();
                return;
            }
        }

        public void showPassword()
        {
            pictureBoxPassword.Image = Image.FromFile(@"img\show.png");
            passwordShown = true;
            textBoxPassword.UseSystemPasswordChar = false;
            return;
        }

        public void hidePassword()
        {
            pictureBoxPassword.Image = Image.FromFile(@"img\hide.png");
            passwordShown = false;
            textBoxPassword.UseSystemPasswordChar = true;
            return;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username == textBoxUsername.Text && password == textBoxPassword.Text)
            {
                isLoggedIn = true;
                if (isLoggedIn == true)
                {
                    this.Hide();
                    FormMain f = new FormMain();
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Credenziali errate.","Log in");
                textBoxUsername.Text = null;
                textBoxPassword.Text = null;
                isLoggedIn = false;
                hidePassword();
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Select();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
