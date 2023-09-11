using Newtonsoft.Json;
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
        bool passwordShown = false;

        bool isLoggedIn=false;

        string hours_minutes = DateTime.Now.ToString("HH : mm");
        string jsonFilePath = @"files\Users.json";

        public FormLogin()
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
            //////////////////////////////////
            //this.Hide();
            //FormMain f = new FormMain();
            //f.ShowDialog();
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

        public List<User> getUsers()
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonText);
            return users;
        }    

        public bool isPasswordCorrect(string username, string password)
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonText);

            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int getUserIndex(string username, string password)
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonText);

            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return i;
                }
            }
            return 999;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isPasswordCorrect(textBoxUsername.Text, textBoxPassword.Text))
            {  
                isLoggedIn = true;
                if (isLoggedIn == true)
                {
                    this.Hide();
                    int userIndex = getUserIndex(textBoxUsername.Text, textBoxPassword.Text);
                    List<User> u = getUsers();
                    FormMain f = new FormMain(u[userIndex]);
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

        public List<User> leggiFileJson(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    string jsonText = File.ReadAllText(jsonFilePath);
                    List<User> user = JsonConvert.DeserializeObject<List<User>>(jsonText);
                    return user;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                File.WriteAllText(jsonFilePath, "[]");
            }
            return new List<User>();
        }

        private void linkLabelRegistrati_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrati f = new FormRegistrati();
            this.Hide();
            f.ShowDialog();
        }
    }
}
