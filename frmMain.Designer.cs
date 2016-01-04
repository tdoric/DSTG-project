namespace Operacijski_sustavi_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsimetricno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPotpisivanje = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsimetricno);
            this.groupBox1.Location = new System.Drawing.Point(225, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kriptiranje";
            // 
            // btnAsimetricno
            // 
            this.btnAsimetricno.Location = new System.Drawing.Point(88, 38);
            this.btnAsimetricno.Name = "btnAsimetricno";
            this.btnAsimetricno.Size = new System.Drawing.Size(149, 45);
            this.btnAsimetricno.TabIndex = 1;
            this.btnAsimetricno.Text = "RSA (asimetrično)";
            this.btnAsimetricno.UseVisualStyleBackColor = true;
            this.btnAsimetricno.Click += new System.EventHandler(this.btnAsimetricno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPotpisivanje);
            this.groupBox2.Location = new System.Drawing.Point(225, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potpisivanje";
            // 
            // btnPotpisivanje
            // 
            this.btnPotpisivanje.Location = new System.Drawing.Point(88, 33);
            this.btnPotpisivanje.Name = "btnPotpisivanje";
            this.btnPotpisivanje.Size = new System.Drawing.Size(149, 45);
            this.btnPotpisivanje.TabIndex = 1;
            this.btnPotpisivanje.Text = "Potpisivanje";
            this.btnPotpisivanje.UseVisualStyleBackColor = true;
            this.btnPotpisivanje.Click += new System.EventHandler(this.btnPotpisivanje_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSTG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsimetricno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPotpisivanje;
    }
}

