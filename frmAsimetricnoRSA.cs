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
    public partial class frmAsimetricnoRSA : Form
    {
        public frmAsimetricnoRSA()
        {
            InitializeComponent();
           
        }

        string privatniKljuc;
        string javniKljuc;
        string nekriptiraniText;
        string kriptiraniText;
        RSACryptoServiceProvider rsa;
        byte[] encrypted;

        private void btnKljucRSA_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider(1024);
            privatniKljuc = Convert.ToBase64String(rsa.ExportCspBlob(true));
            javniKljuc = Convert.ToBase64String(rsa.ExportCspBlob(false));
            System.IO.File.WriteAllText(@"c:\Users\Tomislav\Desktop\OSproject\privatni_kljuc.txt", privatniKljuc);
            System.IO.File.WriteAllText(@"c:\Users\Tomislav\Desktop\OSproject\javni_kljuc.txt", javniKljuc);
           
            MessageBox.Show("Ključevi su generirani!");
        }

        private void btnOpenFileRSA_Click(object sender, EventArgs e)
        {
            if (openFileDialogRSAKript.ShowDialog() == DialogResult.OK)
            {
                txtPutanjaRSA.Text = System.IO.Path.GetFullPath(openFileDialogRSAKript.FileName);
                txtDatotekaRSA.Text = System.IO.Path.GetFileName(openFileDialogRSAKript.FileName);
                nekriptiraniText = System.IO.File.ReadAllText(openFileDialogRSAKript.FileName);
            }
        }

        private void btnKriptirajRSA_Click(object sender, EventArgs e)
        {
            if (!txtPutanjaRSA.Text.Equals("") && !txtDatotekaRSA.Text.Equals(""))
            {
                byte[] original = Encoding.UTF8.GetBytes(nekriptiraniText);

                encrypted = RSAclass.RSAEncrypt(original, rsa.ExportParameters(false) ,false);

                string kriptirano = Convert.ToBase64String(encrypted);

                txtKriptiraniRSA.Text = kriptirano;

                System.IO.File.WriteAllText(@"c:\Users\Tomislav\Desktop\OSproject\rsa_kriptirano.txt", kriptirano);

                MessageBox.Show("Tekst je kriptiran!");

            }
            else
            {
                MessageBox.Show("Niste odabrali datoteku!");
            }
        }

        private void btnOpenFileDekriptRSA_Click(object sender, EventArgs e)
        {
            if (openFileDialogRSADekript.ShowDialog() == DialogResult.OK)
            {
                txtPutanjaDekriptRSA.Text = System.IO.Path.GetFullPath(openFileDialogRSADekript.FileName);
                txtDatotekaDekriptRSA.Text = System.IO.Path.GetFileName(openFileDialogRSADekript.FileName);

                kriptiraniText = System.IO.File.ReadAllText(openFileDialogRSADekript.FileName);
            }
        }

        private void btnDekriptirajRSA_Click(object sender, EventArgs e)
        {
            if (!txtKriptiraniRSA.Text.Equals("") && !txtDatotekaRSA.Text.Equals(""))
            {
                byte[] kriptiraniDatoteka = Convert.FromBase64String(kriptiraniText);

                byte[] decrypted = RSAclass.RSADecrypt(kriptiraniDatoteka, rsa.ExportParameters(true), false);

                string dekriptirano = Encoding.UTF8.GetString(decrypted);
                
                txtDekriptiraniRSA.Text = dekriptirano;

                System.IO.File.WriteAllText(@"c:\Users\Tomislav\Desktop\OSproject\rsa_dekriptirano.txt", dekriptirano);

                MessageBox.Show("Tekst dekriptiran!");

            }
            else
            {
                MessageBox.Show("Odaberite datoteku!");
            }
        }
    }
}
