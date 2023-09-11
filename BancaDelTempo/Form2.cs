using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BancaDelTempo
{
    public partial class FormMain : Form
    {
        string hours_minutes = DateTime.Now.ToString("HH : mm");
        string elencoSociJsonPath = @"files\ElencoSoci.json";
        public FormMain(User user)
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();

            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btnLogout.Width - 4, btnLogout.Height - 4);
            btnLogout.Region = new Region(p);
            btnSettings.Region = new Region(p);

            uploadUserImage();

            lblUser.Text = user.Username;
            lblDebito.Text = "Debito: " + user.Debito;

            aggiungiAListView();
            pnlSettings.Hide();
            pnlSegreteria.Hide();

            pnlSoci.Location = new Point(315, 12);
            pnlSettings.Location = new Point(315, 12);
            pnlSegreteria.Location = new Point(315, 12);
        }

        public void aggiungiAListView()
        {
            List<Socio> listSoci = leggiFileJson(elencoSociJsonPath);

            foreach (var s in listSoci)
            {
                ListViewItem item = new ListViewItem(s.Cognome);
                item.SubItems.Add(s.Nome);
                item.SubItems.Add(s.Telefono);
                item.SubItems.Add(s.Debito.ToString());

                listViewSettings.Items.Add(item);
            }
            foreach (var s in listSoci)
            {
                if (s.Debito != 0)
                {
                    ListViewItem item = new ListViewItem(s.Cognome);
                    item.SubItems.Add(s.Nome);
                    item.SubItems.Add(s.Telefono);
                    item.SubItems.Add(s.Debito.ToString());

                    listViewElencoSoci.Items.Add(item);
                }
            }

            foreach (var s in listSoci)
            {
                ListViewItem item = new ListViewItem(s.Cognome);
                item.SubItems.Add(s.Nome);
                item.SubItems.Add(s.Telefono);

                listViewSegreteria.Items.Add(item);
            }
            listSoci = leggiFileJson(elencoSociJsonPath);
        }

        public void refreshJsonFile(List<Socio> ls, string path)
        {
            string nuovoJsonText = JsonConvert.SerializeObject(ls, Formatting.Indented);
            File.WriteAllText(path, nuovoJsonText);
        }

        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm");
        }

        private void btnApriFileJSON_Click(object sender, EventArgs e)
        {
            try
            {
                //path del file
                string exeFolder = Application.StartupPath;
                string filePath = System.IO.Path.Combine(exeFolder, elencoSociJsonPath);

                //verifica dell'esistenza del file
                if (System.IO.File.Exists(filePath))
                {
                    //apre il file con notepad
                    Process.Start("notepad.exe", filePath);
                }
                else
                {
                    MessageBox.Show("Il file non esiste.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public List<Socio> leggiFileJson(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    string jsonText = File.ReadAllText(jsonFilePath);
                    List<Socio> soci = JsonConvert.DeserializeObject<List<Socio>>(jsonText);
                    return soci;
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
            return new List<Socio>();
        }

        public void aggiungiSocioJson(string jsonFilePath, Socio nuovoSocio)
        {
            List<Socio> soci = leggiFileJson(elencoSociJsonPath);
            soci.Add(nuovoSocio);
            string nuovoJsonText = JsonConvert.SerializeObject(soci, Formatting.Indented);
            File.WriteAllText(jsonFilePath, nuovoJsonText);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            listViewSettings.Items.Clear();
            aggiungiAListView();
            pnlSoci.Hide();
            pnlSettings.Show();
            pnlSegreteria.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            listViewElencoSoci.Items.Clear();
            aggiungiAListView();
            pnlSettings.Hide();
            pnlSoci.Show();
            pnlSegreteria.Hide();
        }

        private void btnImpostazioniEliminaSocio_Click(object sender, EventArgs e)
        {
            if (listViewSettings.Items.Count > 0)
            {
                ListViewItem selectedItem = listViewSettings.SelectedItems[0];
                string telefonoSocio = selectedItem.SubItems[2].Text;

                List<Socio> elencoTmp = leggiFileJson(elencoSociJsonPath);
                for (int i = 0; i < elencoTmp.Count(); i++)
                {
                    if (elencoTmp[i].Telefono == telefonoSocio)
                    {
                        elencoTmp.RemoveAt(i);
                    }
                }
                listViewSettings.Items.Remove(listViewSettings.SelectedItems[0]);
                refreshJsonFile(elencoTmp, elencoSociJsonPath);
                listViewElencoSoci.Items.Clear();
                listViewSettings.Items.Clear();
                aggiungiAListView();
            }
        }

        private void btnImpostazioniAggiungiSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCognome.Text)
                || string.IsNullOrEmpty(textBoxNome.Text)
                || string.IsNullOrEmpty(textBoxTelefono.Text)
                || string.IsNullOrEmpty(textBoxDebito.Text))
            {
                return;
            }
            else
            {
                try
                {
                    Socio s = new Socio(textBoxCognome.Text, textBoxNome.Text,
                        textBoxTelefono.Text, Convert.ToInt32(textBoxDebito.Text));

                    aggiungiSocioJson(elencoSociJsonPath, s);
                    listViewSettings.Items.Clear();
                    listViewElencoSoci.Items.Clear();
                    aggiungiAListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                textBoxCognome.Text = "Cognome";
                textBoxNome.Text = "Nome";
                textBoxTelefono.Text = "Telefono";
                textBoxDebito.Text = "Debito";
            }
            
        }

        private void textBoxCognome_Click(object sender, EventArgs e)
        {
            textBoxCognome.Text = null;
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = null;
        }

        private void textBoxTelefono_Click(object sender, EventArgs e)
        {
            textBoxTelefono.Text = null;
        }

        private void textBoxDebito_Click(object sender, EventArgs e)
        {
            textBoxDebito.Text = null;
        }

        private void btnUserUploadPhoto_Click(object sender, EventArgs e)
        {
            String img = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";


                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    img = dialog.FileName;
                    pictureBoxUser.ImageLocation = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            userImage();
            string imgUserAdded = pictureBoxUser.ImageLocation.ToString();
            MessageBox.Show("Path: " + imgUserAdded, "Image added!");
        }

        public void userImage()
        {
            string imgFilePath = @"img\user\userImgPath.txt";
            string imgUserAdded = pictureBoxUser.ImageLocation.ToString();

            //verifica se il file esiste
            if (!File.Exists(imgFilePath))
            {
                //file non esiste
                using (StreamWriter sw = new StreamWriter(imgFilePath))
                {
                    sw.WriteLine(imgUserAdded);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(imgFilePath))
                {
                    // Scrivi dei dati nel file
                    sw.WriteLine(imgUserAdded);
                    sw.Close();
                }
            }
        }

        public void uploadUserImage()
        {
            string imgFilePath = @"img\user\userImgPath.txt";

            //verifica se il file esiste
            if (File.Exists(imgFilePath))
            {
                using (StreamReader sr = new StreamReader(imgFilePath))
                {
                    string linePath = sr.ReadLine();
                    pictureBoxUser.ImageLocation = linePath;
                    sr.Close();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBoxUser.Image = Image.FromFile(@"img\user.png");
            try
            {
                if (File.Exists(@"img\user\userImgPath.txt"))
                {
                    //cancella file
                    File.Delete(@"img\user\userImgPath.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApriFileJson2_Click(object sender, EventArgs e)
        {
            try
            {
                //path del file
                string exeFolder = Application.StartupPath;
                string filePath = System.IO.Path.Combine(exeFolder, elencoSociJsonPath);

                //verifica dell'esistenza del file
                if (System.IO.File.Exists(filePath))
                {
                    //apre il file con notepad
                    Process.Start("notepad.exe", filePath);
                }
                else
                {
                    MessageBox.Show("Il file non esiste.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSegreteria_Click(object sender, EventArgs e)
        {
            pnlSoci.Hide();
            pnlSegreteria.Show();
            listViewSegreteria.Items.Clear();

            aggiungiAListView();
        }

        private void btnApriFileJsonSegreteria_Click(object sender, EventArgs e)
        {
            btnApriFileJSON_Click(sender, e);
        }
    }

}
