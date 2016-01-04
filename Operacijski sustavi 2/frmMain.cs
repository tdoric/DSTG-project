using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operacijski_sustavi_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            string original = "Što se bijeli u gori zelenoj, nit je snijeg nit su labudovi.";
            System.IO.File.WriteAllText("original.txt", original);
        }

        private void btnSazetak_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSimetricno_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAsimetricno_Click(object sender, EventArgs e)
        {
            frmAsimetricnoRSA frmAsimetricniRSA = new frmAsimetricnoRSA();
            frmAsimetricniRSA.Show();
        }

        private void btnPotpisivanje_Click(object sender, EventArgs e)
        {
            frmPotpis frmPotpis = new frmPotpis();
            frmPotpis.Show();
        }
    }
}
