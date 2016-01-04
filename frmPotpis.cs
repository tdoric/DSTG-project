using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Operacijski_sustavi_2
{
    public partial class frmPotpis : Form
    {
        public frmPotpis()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(2048);
        }

        RSACryptoServiceProvider rsa;
        String originalText;
        byte[] kriptiraniHashOriginal;

        private void btnOpenFilePotpis_Click(object sender, EventArgs e)
        {
            
            if (openFileDialogPotpis.ShowDialog() == DialogResult.OK)
            {
                txtPutanjaPotpis.Text = System.IO.Path.GetFullPath(openFileDialogPotpis.FileName);
                txtDatotekaPotpis.Text = System.IO.Path.GetFileName(openFileDialogPotpis.FileName);

                originalText = System.IO.File.ReadAllText(openFileDialogPotpis.FileName);
            }
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            if (!txtDatotekaPotpis.Text.Equals(""))
            {
                byte[] original = Encoding.UTF8.GetBytes(originalText);

                kriptiraniHashOriginal = RSAclass.HashAndSign(original, rsa.ExportParameters(true));

                MessageBox.Show("Digitalni potpis izvršen!");
            }
            else
            {
                MessageBox.Show("Odaberite datoteku!");
            }
            
        }

        private void btnProvjeriPotpis_Click(object sender, EventArgs e)
        {
            if (!txtDatotekaPotpis.Text.Equals(""))
            {

                originalText = System.IO.File.ReadAllText(openFileDialogPotpis.FileName);
                byte[] original = Encoding.UTF8.GetBytes(originalText);
                bool OK = RSAclass.VerifyHash(original, kriptiraniHashOriginal, rsa.ExportParameters(false));

                


                if (OK == true)
                {
                    lblPotpisValjan.BackColor = Color.Green;
                    lblPotpisValjan.Text = "Potpis je valjan!!";
                    
                }
                else
                {
                    lblPotpisValjan.BackColor = Color.Orange;
                    lblPotpisValjan.Text = "Potpis nije valjan!!";
                }
            }
            else
            {
                MessageBox.Show("Odaberite datoteku!");
            }
            
        }
    }
}
