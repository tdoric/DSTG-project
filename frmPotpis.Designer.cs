namespace Operacijski_sustavi_2
{
    partial class frmPotpis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPotpis));
            this.txtDatotekaPotpis = new System.Windows.Forms.TextBox();
            this.lblDatotekaPotpis = new System.Windows.Forms.Label();
            this.lblPutanjaPotpis = new System.Windows.Forms.Label();
            this.txtPutanjaPotpis = new System.Windows.Forms.TextBox();
            this.btnOpenFilePotpis = new System.Windows.Forms.Button();
            this.btnPotpisi = new System.Windows.Forms.Button();
            this.btnProvjeriPotpis = new System.Windows.Forms.Button();
            this.openFileDialogPotpis = new System.Windows.Forms.OpenFileDialog();
            this.lblPotpisValjan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatotekaPotpis
            // 
            this.txtDatotekaPotpis.Location = new System.Drawing.Point(12, 78);
            this.txtDatotekaPotpis.Name = "txtDatotekaPotpis";
            this.txtDatotekaPotpis.ReadOnly = true;
            this.txtDatotekaPotpis.Size = new System.Drawing.Size(309, 20);
            this.txtDatotekaPotpis.TabIndex = 19;
            // 
            // lblDatotekaPotpis
            // 
            this.lblDatotekaPotpis.AutoSize = true;
            this.lblDatotekaPotpis.Location = new System.Drawing.Point(12, 59);
            this.lblDatotekaPotpis.Name = "lblDatotekaPotpis";
            this.lblDatotekaPotpis.Size = new System.Drawing.Size(54, 13);
            this.lblDatotekaPotpis.TabIndex = 18;
            this.lblDatotekaPotpis.Text = "Datoteka:";
            // 
            // lblPutanjaPotpis
            // 
            this.lblPutanjaPotpis.AutoSize = true;
            this.lblPutanjaPotpis.Location = new System.Drawing.Point(12, 9);
            this.lblPutanjaPotpis.Name = "lblPutanjaPotpis";
            this.lblPutanjaPotpis.Size = new System.Drawing.Size(91, 13);
            this.lblPutanjaPotpis.TabIndex = 17;
            this.lblPutanjaPotpis.Text = "Putanja datoteke:";
            // 
            // txtPutanjaPotpis
            // 
            this.txtPutanjaPotpis.Location = new System.Drawing.Point(12, 28);
            this.txtPutanjaPotpis.Name = "txtPutanjaPotpis";
            this.txtPutanjaPotpis.Size = new System.Drawing.Size(309, 20);
            this.txtPutanjaPotpis.TabIndex = 16;
            // 
            // btnOpenFilePotpis
            // 
            this.btnOpenFilePotpis.Location = new System.Drawing.Point(348, 28);
            this.btnOpenFilePotpis.Name = "btnOpenFilePotpis";
            this.btnOpenFilePotpis.Size = new System.Drawing.Size(114, 23);
            this.btnOpenFilePotpis.TabIndex = 15;
            this.btnOpenFilePotpis.Text = "Odaberite datoteku";
            this.btnOpenFilePotpis.UseVisualStyleBackColor = true;
            this.btnOpenFilePotpis.Click += new System.EventHandler(this.btnOpenFilePotpis_Click);
            // 
            // btnPotpisi
            // 
            this.btnPotpisi.Location = new System.Drawing.Point(12, 136);
            this.btnPotpisi.Name = "btnPotpisi";
            this.btnPotpisi.Size = new System.Drawing.Size(137, 23);
            this.btnPotpisi.TabIndex = 21;
            this.btnPotpisi.Text = "Potpiši";
            this.btnPotpisi.UseVisualStyleBackColor = true;
            this.btnPotpisi.Click += new System.EventHandler(this.btnPotpisi_Click);
            // 
            // btnProvjeriPotpis
            // 
            this.btnProvjeriPotpis.Location = new System.Drawing.Point(188, 136);
            this.btnProvjeriPotpis.Name = "btnProvjeriPotpis";
            this.btnProvjeriPotpis.Size = new System.Drawing.Size(133, 23);
            this.btnProvjeriPotpis.TabIndex = 22;
            this.btnProvjeriPotpis.Text = "Provjeri potpis";
            this.btnProvjeriPotpis.UseVisualStyleBackColor = true;
            this.btnProvjeriPotpis.Click += new System.EventHandler(this.btnProvjeriPotpis_Click);
            // 
            // openFileDialogPotpis
            // 
            this.openFileDialogPotpis.FileName = "openFileDialog1";
            // 
            // lblPotpisValjan
            // 
            this.lblPotpisValjan.AutoSize = true;
            this.lblPotpisValjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotpisValjan.Location = new System.Drawing.Point(184, 167);
            this.lblPotpisValjan.Name = "lblPotpisValjan";
            this.lblPotpisValjan.Size = new System.Drawing.Size(0, 24);
            this.lblPotpisValjan.TabIndex = 23;
            // 
            // frmPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 274);
            this.Controls.Add(this.lblPotpisValjan);
            this.Controls.Add(this.btnProvjeriPotpis);
            this.Controls.Add(this.btnPotpisi);
            this.Controls.Add(this.txtDatotekaPotpis);
            this.Controls.Add(this.lblDatotekaPotpis);
            this.Controls.Add(this.lblPutanjaPotpis);
            this.Controls.Add(this.txtPutanjaPotpis);
            this.Controls.Add(this.btnOpenFilePotpis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPotpis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalni potpis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatotekaPotpis;
        private System.Windows.Forms.Label lblDatotekaPotpis;
        private System.Windows.Forms.Label lblPutanjaPotpis;
        private System.Windows.Forms.TextBox txtPutanjaPotpis;
        private System.Windows.Forms.Button btnOpenFilePotpis;
        private System.Windows.Forms.Button btnPotpisi;
        private System.Windows.Forms.Button btnProvjeriPotpis;
        private System.Windows.Forms.OpenFileDialog openFileDialogPotpis;
        private System.Windows.Forms.Label lblPotpisValjan;
    }
}