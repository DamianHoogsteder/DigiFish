using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiFish_application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginscherm = new Login();
            loginscherm.TopLevel = false;
            pnl_home.Controls.Add(loginscherm);
            loginscherm.Show();
        }

        private void digiFishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DigifishScreen digifish = new DigifishScreen();
            digifish.TopLevel = false;
            pnl_home.Controls.Add(digifish);
            digifish.Show();
        }

        private void visInformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visInformatie visInformatie = new visInformatie();
            visInformatie.TopLevel = false;
            pnl_home.Controls.Add(visInformatie);
            visInformatie.Show();
        }
    }
}
