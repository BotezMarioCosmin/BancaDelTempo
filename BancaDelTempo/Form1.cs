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
    public partial class Login : Form
    {
        string hours_minutes = DateTime.Now.ToString("HH : mm");
        public Login()
        {
            InitializeComponent();
            lblTimeLive.Text = hours_minutes;
            timerTimeLive.Start();
        }

        private void timerTimeLive_Tick(object sender, EventArgs e)
        {
            lblTimeLive.Text = DateTime.Now.ToString("HH : mm");
        }
    }
}
