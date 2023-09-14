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
        DateTime date = DateTime.Now;
        List<string> prestazioni = new List<string>();
        List<string> beneficiari = new List<string>();
        User utente = null;
        public FormMain(User user)
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
            utente = user;

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
            pnlPrestazioni.Hide();

            pnlSoci.Location = new Point(315, 12);
            pnlSettings.Location = new Point(315, 12);
            pnlSegreteria.Location = new Point(315, 12);
            pnlPrestazioni.Location = new Point(315, 12);

            comboBoxData.Items.Add(date.ToString());
            comboBoxData.SelectedIndex = 0;
            comboBoxData.Enabled= false;

            if (!user.Admin)
            {
                listViewSettings.Hide();
                btnImpostazioniEliminaSocio.Hide();
                btnApriFileJson2.Hide();
                btnImpostazioniAggiungiSocio.Hide();
                lblModificaFile.Hide();
                textBoxCognome.Hide();
                textBoxNome.Hide();
                textBoxTelefono.Hide();
                textBoxDebito.Hide();
            }

            prestazioni.Add("Riparazione");
            prestazioni.Add("Lezione");
            prestazioni.Add("Baby Sitter");
            prestazioni.Add("Taglio erba");
            prestazioni.Add("Pitturare casa");
            prestazioni.Add("Torta");
            prestazioni.Add("Pulizia");
            prestazioni.Add("Fotografia");
            prestazioni.Add("Personal Training");
            prestazioni.Add("Traduzione");
            prestazioni.Add("Guida Turistica");
            for (int i = 0; i < prestazioni.Count(); i++)
            {
                comboBoxPrestazione.Items.Add(prestazioni[i]);
            }

            beneficiari = getBeneficiari();
            for (int i = 0; i < beneficiari.Count(); i++)
            {
                comboBoxBeneficiario.Items.Add(beneficiari[i]);
            }
        }

        public List<String> getBeneficiari()
        {
            List<Socio> ls = leggiFileJson(elencoSociJsonPath);
            List<String> beneficiari = new List<String>();
            foreach (var v in ls)
            {
                string tmp = v.Cognome+" "+v.Nome;
                beneficiari.Add(tmp);
            }
            return beneficiari;
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
                item.SubItems.Add(s.Zona);

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
                item.SubItems.Add(s.Zona);
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
            pnlPrestazioni.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            listViewElencoSoci.Items.Clear();
            aggiungiAListView();
            pnlSettings.Hide();
            pnlSoci.Show();
            pnlSegreteria.Hide();
            pnlPrestazioni.Hide();  
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
            if (textBoxTelefono.Text.Length != 10)
            {
                MessageBox.Show("il Telefono deve essere composto da 10 cifre!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxCognome.Text)
        || string.IsNullOrEmpty(textBoxNome.Text)
        || string.IsNullOrEmpty(textBoxTelefono.Text)
        || string.IsNullOrEmpty(textBoxDebito.Text)
        || string.IsNullOrEmpty(textBoxZona.Text))
                {
                    return;
                }
                else
                {
                    try
                    {
                        Socio s = new Socio(textBoxCognome.Text, textBoxNome.Text,
                            textBoxTelefono.Text, Convert.ToInt32(textBoxDebito.Text), textBoxZona.Text);

                        aggiungiSocioJson(elencoSociJsonPath, s);
                        listViewSettings.Items.Clear();
                        listViewElencoSoci.Items.Clear();
                        aggiungiAListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }

            textBoxCognome.Text = "Cognome";
            textBoxNome.Text = "Nome";
            textBoxTelefono.Text = "Telefono";
            textBoxDebito.Text = "Debito";
            textBoxZona.Text = "Zona";
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
            btnApriFileJSON_Click(sender, e);
        }

        private void btnSegreteria_Click(object sender, EventArgs e)
        {
            pnlPrestazioni.Hide();
            pnlSoci.Hide();
            pnlSettings.Hide();
            pnlSegreteria.Show();
            listViewSegreteria.Items.Clear();

            aggiungiAListView();
        }

        private void btnApriFileJsonSegreteria_Click(object sender, EventArgs e)
        {
            btnApriFileJSON_Click(sender, e);
        }

        private void btnPrestazioni_Click(object sender, EventArgs e)
        {
            comboBoxPrestazione.Items.Add("Prestazioni");
            comboBoxOre.Items.Add("Ore");
            comboBoxBeneficiario.Items.Add("Beneficiario");

            List<User> utenti = leggiFileJsonUser();
            utenti = modificaDebitoUtente(utenti, utente);
            refreshJsonFileUtente(utenti, @"files\Users.json");

            listViewPrestazioni.Items.Clear();
            aggiungiAListViewPrestazioni();
            pnlSegreteria.Hide();
            pnlSettings.Hide();
            pnlSoci.Hide();
            pnlPrestazioni.Show();
            comboBoxPrestazione.SelectedItem = "Prestazioni";
            comboBoxOre.SelectedItem = "Ore";
            comboBoxBeneficiario.SelectedItem = "Beneficiario";

        }

        private void btnApriFileJson3_Click(object sender, EventArgs e)
        {
            try
            {
                //path del file
                string exeFolder = Application.StartupPath;
                string filePath = System.IO.Path.Combine(exeFolder, @"files\Prestazioni.json");

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

        public List<Prestazione> leggiFileJsonPrestazioni(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    string jsonText = File.ReadAllText(jsonFilePath);
                    List<Prestazione> prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(jsonText);

                    return prestazioni;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                File.WriteAllText(jsonFilePath,"[]");
            }
            return new List<Prestazione>();
        }
        public void aggiungiAListViewPrestazioni()
        {
            List<Prestazione> listPrestazioni = leggiFileJsonPrestazioni(@"files\Prestazioni.json");

            foreach (var s in listPrestazioni)
            {
                ListViewItem item = new ListViewItem(s.Ore.ToString());
                item.SubItems.Add(s.NomePrestazione);
                item.SubItems.Add(s.Data.ToString());
                item.SubItems.Add(s.Prestante);
                item.SubItems.Add(s.Beneficiario);
                listViewPrestazioni.Items.Add(item);
            }
            listPrestazioni = leggiFileJsonPrestazioni(@"files\Prestazioni.json");
        }

        public List<Prestazione> riordinaListViewPrestazioniOre(List<Prestazione> lp)
        {
            return lp.OrderBy(Prestazione => Prestazione.Ore).ToList();
        }

        public List<Prestazione> riordinaListViewPrestazioniPrestazione(List<Prestazione> lp)
        {
            return lp.OrderBy(Prestazione => Prestazione.NomePrestazione).ToList();
        }

        public List<Prestazione> riordinaListViewPrestazioniData(List<Prestazione> lp)
        {
            return lp.OrderBy(Prestazione => Prestazione.Data).ToList();
        }
        public List<Prestazione> riordinaListViewPrestazioniPrestante(List<Prestazione> lp)
        {
            return lp.OrderBy(Prestazione => Prestazione.Prestante).ToList();
        }
        public List<Prestazione> riordinaListViewPrestazioniBeneficiario(List<Prestazione> lp)
        {
            return lp.OrderBy(Prestazione => Prestazione.Beneficiario).ToList();
        }
        private void btnOffriPrestazione_Click(object sender, EventArgs e)
        {
            if (comboBoxOre.Text != "Ore" && comboBoxOre.Text != "" && comboBoxBeneficiario.Text != "Beneficiario"
                && comboBoxBeneficiario.Text != ""
                &&  comboBoxPrestazione.Text != "Prestazione" && comboBoxPrestazione.Text != "")
            {
                MessageBox.Show("Prestazione offerta con successo!");
                utente.SottraiDebito(Convert.ToInt32(comboBoxOre.SelectedItem));
                lblDebito.Text = "Debito: " + utente.Debito.ToString();

                List<User> utenti = leggiFileJsonUser();
                utenti = modificaDebitoUtente(utenti, utente);
                refreshJsonFileUtente(utenti, @"files\Users.json");


                Prestazione p = new Prestazione(Convert.ToInt32(comboBoxOre.Text), comboBoxPrestazione.Text, Convert.ToDateTime(comboBoxData.Text),
                    utente.Cognome + " " + utente.Nome, comboBoxBeneficiario.Text);
                List<Prestazione> lp = leggiFileJsonPrestazioni(@"files\Prestazioni.json");
                aggiungiPrestazioneJson(p);

                listViewPrestazioni.Items.Clear();
                aggiungiAListViewPrestazioni();


                comboBoxPrestazione.Items.Add("Prestazioni");
                comboBoxOre.Items.Add("Ore");
                comboBoxBeneficiario.Items.Add("Beneficiario");
                comboBoxPrestazione.SelectedItem = "Prestazione";
                comboBoxOre.SelectedItem = "Ore";
                comboBoxBeneficiario.SelectedItem = "Beneficiario";
            }
            else
            {
                MessageBox.Show("Valori non validi","Errore");
                comboBoxPrestazione.Items.Add("Prestazioni");
                comboBoxOre.Items.Add("Ore");
                comboBoxBeneficiario.Items.Add("Beneficiario");
                comboBoxPrestazione.SelectedItem = "Prestazione";
                comboBoxOre.SelectedItem = "Ore";
                comboBoxBeneficiario.SelectedItem = "Beneficiario";
            }

        }

            private void comboBoxPrestazione_DropDown(object sender, EventArgs e)
        {
            if (comboBoxPrestazione.Items.Contains("Prestazioni"))
            {
                comboBoxPrestazione.Items.Remove("Prestazioni");
            }
        }

        private void comboBoxOre_DropDown(object sender, EventArgs e)
        {
            if (comboBoxOre.Items.Contains("Ore"))
            {
                comboBoxOre.Items.Remove("Ore");
            }
        }

        private void comboBoxBeneficiario_DropDown(object sender, EventArgs e)
        {
            if (comboBoxBeneficiario.Items.Contains("Beneficiario"))
            {
                comboBoxBeneficiario.Items.Remove("Beneficiario");
            }
        }
        public List<User> leggiFileJsonUser()
        {
            if (File.Exists(@"files\Users.json"))
            {
                try
                {
                    string jsonText = File.ReadAllText(@"files\Users.json");
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
                File.WriteAllText(@"files\Users.json", "[]");
            }
            return new List<User>();
        }
        public void refreshJsonFileUtente(List<User> ls, string path)
        {
            string nuovoJsonText = JsonConvert.SerializeObject(ls, Formatting.Indented);
            File.WriteAllText(path, nuovoJsonText);
        }

        public List<User> modificaDebitoUtente(List<User> utenti, User utente)
        {
            for (int i = 0; i < utenti.Count(); i++)
            {
                if (utenti[i].Telefono == utente.Telefono)
                {
                    utenti[i].Debito = utente.Debito;
                }
            }
            return utenti;
        }

        public List<Prestazione> leggiPrestazioni()
        {
            if (File.Exists(@"files\Prestazioni.json"))
            {
                try
                {
                    string jsonText = File.ReadAllText(@"files\Prestazioni.json");
                    List<Prestazione> prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(jsonText);
                    return prestazioni;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                File.WriteAllText(@"files\Prestazioni.json", "[]");
            }
            return new List<Prestazione>();
        }
        public void aggiungiPrestazioneJson(Prestazione pr)
        {
            List<Prestazione> lp = leggiPrestazioni();
            lp.Add(pr);
            string nuovoJsonText = JsonConvert.SerializeObject(lp, Formatting.Indented);
            File.WriteAllText(@"files\Prestazioni.json", nuovoJsonText);
        }
        public void refreshJsonFilePrestazioni(List<Prestazione> lp)
        {
            string nuovoJsonText = JsonConvert.SerializeObject(lp, Formatting.Indented);
            File.WriteAllText(@"files\Prestazioni.json", nuovoJsonText);
        }

        private void checkBoxOrdinaOre_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonOre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOre.Checked == true)
            {
                listViewPrestazioni.Items.Clear();
                refreshJsonFilePrestazioni(riordinaListViewPrestazioniOre(leggiPrestazioni()));
                aggiungiAListViewPrestazioni();
            }
            else { listViewPrestazioni.Items.Clear(); refreshJsonFilePrestazioni(leggiPrestazioni()); aggiungiAListViewPrestazioni(); }

        }

        private void radioButtonData_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonData.Checked == true)
            {
                listViewPrestazioni.Items.Clear();
                refreshJsonFilePrestazioni(riordinaListViewPrestazioniData(leggiPrestazioni()));
                aggiungiAListViewPrestazioni();
            }
            else { listViewPrestazioni.Items.Clear(); refreshJsonFilePrestazioni(leggiPrestazioni()); aggiungiAListViewPrestazioni(); }

        }

        private void radioButtonPrestazione_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrestazione.Checked == true)
            {
                listViewPrestazioni.Items.Clear();
                refreshJsonFilePrestazioni(riordinaListViewPrestazioniPrestazione(leggiPrestazioni()));
                aggiungiAListViewPrestazioni();
            }
            else { listViewPrestazioni.Items.Clear(); refreshJsonFilePrestazioni(leggiPrestazioni()); aggiungiAListViewPrestazioni(); }

        }

        private void radioButtonPrestante_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrestazione.Checked == true)
            {
                listViewPrestazioni.Items.Clear();
                refreshJsonFilePrestazioni(riordinaListViewPrestazioniPrestante(leggiPrestazioni()));
                aggiungiAListViewPrestazioni();
            }
            else { listViewPrestazioni.Items.Clear(); refreshJsonFilePrestazioni(leggiPrestazioni()); aggiungiAListViewPrestazioni(); }

        }

        private void radioBeneficiario_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBeneficiario.Checked == true)
            {
                listViewPrestazioni.Items.Clear();
                refreshJsonFilePrestazioni(riordinaListViewPrestazioniBeneficiario(leggiPrestazioni()));
                aggiungiAListViewPrestazioni();
            }
            else { listViewPrestazioni.Items.Clear(); refreshJsonFilePrestazioni(leggiPrestazioni()); aggiungiAListViewPrestazioni(); }

        }

        private void textBoxZona_Click(object sender, EventArgs e)
        {
            textBoxZona.Text = null;
        }
    }

}
