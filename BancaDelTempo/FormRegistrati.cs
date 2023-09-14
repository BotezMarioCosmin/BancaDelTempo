using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    
namespace BancaDelTempo
{
    public partial class FormRegistrati : Form
    {
        bool passwordShown = false;
        string hours_minutes = DateTime.Now.ToString("HH : mm");
        string jsonFilePath = @"files\Users.json";
        public FormRegistrati()
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
            /*
             *     "Username": "mario",
                    "Password": "2005",
                    "Admin": "true",
                    "Cognome": "Botez",
                    "Nome": "Mario Cosmin",
                    "Telefono": "3858372639",
                    "Debito": 45
             */
        }
        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "Username" && textBoxUsername.Text != null &&
                textBoxPassword.Text != "Password" && textBoxPassword.Text != null &&
                textBoxCognome.Text != "Cognome" && textBoxCognome.Text != null &&
                textBoxNome.Text != "Nome" && textBoxNome.Text != null &&
                textBoxTelefono.Text != "Telefono" && textBoxTelefono.Text != null)
            {
                try
                {
                    User user = new User(textBoxCognome.Text, textBoxNome.Text, textBoxTelefono.Text, 0, textBoxZona.Text, textBoxUsername.Text, textBoxPassword.Text, false);
                    aggiungiUserJson(jsonFilePath, user);
                    textBoxUsername.Text = "Username";
                    textBoxPassword.Text = "Password";
                    textBoxCognome.Text = "Cognome";
                    textBoxNome.Text = "Nome";
                    textBoxTelefono.Text = "Telefono";
                    MessageBox.Show("Registrato con successo!", "Registrazione");
                    this.Hide();
                    FormLogin f = new FormLogin();
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Valori non validi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            if (passwordShown == false)
            {
                showPassword();
                return;
            }
            else if (passwordShown == true)
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

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
        }

        private void textBoxCognome_Click(object sender, EventArgs e)
        {
            textBoxCognome.Clear();
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
        }

        private void textBoxTelefono_Click(object sender, EventArgs e)
        {
            textBoxTelefono.Clear();
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
            textBoxPassword.UseSystemPasswordChar = true;
            if (e.KeyCode == Keys.Enter)
            {
                textBoxCognome.Select();
            }
        }

        private void textBoxCognome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNome.Select();
            }
        }

        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxTelefono.Select();
            }
        }

        private void textBoxTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxTelefono.Select();
            }

        }
        public void refreshJsonFile(List<User> ls, string path)
        {
            string nuovoJsonText = JsonConvert.SerializeObject(ls, Formatting.Indented);
            File.WriteAllText(path, nuovoJsonText);
        }
        public void aggiungiUserJson(string jsonFilePath, User nuovoUser)
        {
            List<User> user = leggiFileJson(jsonFilePath);
            user.Add(nuovoUser);
            string nuovoJsonText = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText(jsonFilePath, nuovoJsonText);
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

        private void textBoxZona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrati_Click(sender, e);
            }
        }

        private void textBoxZona_Click(object sender, EventArgs e)
        {
            textBoxZona.Clear();
        }
    }
}
