using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaDelTempo
{
    public partial class FormMain : Form
    {
        string hours_minutes = DateTime.Now.ToString("HH : mm : ss");
        public FormMain()
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
        }

        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlHome.Show();
        }

        public void hidePanels()
        {
            pnlHome.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
