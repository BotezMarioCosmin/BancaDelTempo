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

        public FormMain()
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();

            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btnLogout.Width - 4, btnLogout.Height - 4);
            btnLogout.Region = new Region(p);

            lblUser.Text = leggiParametroUser(@"files\user.txt", 0);
            lblDebito.Text = "Debito: " + leggiParametroUser(@"files\user.txt", 5);

            aggiungiAListView();
        }

        public string leggiParametroUser(string filePath, int index)
        {
            StreamReader sr = new StreamReader(filePath);
            List<string> listUser = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                listUser.Add(sr.ReadLine());
            }
            sr.Close();
            return listUser[index];
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

                listViewElencoSoci.Items.Add(item);
            }
        }

        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm");
        }


        private void btnAggiungiSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAggiungiSocioCognome.Text)
                || string.IsNullOrEmpty(textBoxAggiungiSocioNome.Text)
                || string.IsNullOrEmpty(textBoxAggiungiSocioTelefono.Text)
                || string.IsNullOrEmpty(textBoxAggiungiSocioDebito.Text))
            {
                return;
            }
            else
            {
                try
                {
                    Socio s = new Socio(textBoxAggiungiSocioCognome.Text, textBoxAggiungiSocioNome.Text,
                        textBoxAggiungiSocioTelefono.Text, Convert.ToInt32(textBoxAggiungiSocioDebito.Text));

                    aggiungiSocioJson(elencoSociJsonPath, s);
                    listViewElencoSoci.Items.Clear();
                    aggiungiAListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }

                textBoxAggiungiSocioCognome.Clear();
                textBoxAggiungiSocioNome.Clear();
                textBoxAggiungiSocioTelefono.Clear();
            }
        }

        private void btnEliminaSocio_Click(object sender, EventArgs e)
        {
            if (listViewElencoSoci.Items.Count>0)
            {
                listViewElencoSoci.Items.Remove(listViewElencoSoci.SelectedItems[0]);
            }
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
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public List<Socio> leggiFileJson(string jsonFilePath)
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            List<Socio> soci = JsonConvert.DeserializeObject<List<Socio>>(jsonText);
            return soci;
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
    }
}
