namespace Klijent
{
    partial class FrmPrijavljivanje
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
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImeGreska = new System.Windows.Forms.Label();
            this.lblSifraGreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(187, 67);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(164, 26);
            this.txtKorisnickoIme.TabIndex = 0;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(187, 132);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(164, 26);
            this.txtSifra.TabIndex = 1;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(187, 211);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(164, 40);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifra";
            // 
            // lblImeGreska
            // 
            this.lblImeGreska.AutoSize = true;
            this.lblImeGreska.Location = new System.Drawing.Point(183, 96);
            this.lblImeGreska.Name = "lblImeGreska";
            this.lblImeGreska.Size = new System.Drawing.Size(61, 20);
            this.lblImeGreska.TabIndex = 5;
            this.lblImeGreska.Text = "Greska";
            this.lblImeGreska.Visible = false;
            // 
            // lblSifraGreska
            // 
            this.lblSifraGreska.AutoSize = true;
            this.lblSifraGreska.Location = new System.Drawing.Point(183, 161);
            this.lblSifraGreska.Name = "lblSifraGreska";
            this.lblSifraGreska.Size = new System.Drawing.Size(61, 20);
            this.lblSifraGreska.TabIndex = 6;
            this.lblSifraGreska.Text = "Greska";
            this.lblSifraGreska.Visible = false;
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 336);
            this.Controls.Add(this.lblSifraGreska);
            this.Controls.Add(this.lblImeGreska);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Name = "FrmPrijavljivanje";
            this.Text = "Prijavi se ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnPrijaviSe;
        public System.Windows.Forms.TextBox txtKorisnickoIme;
        public System.Windows.Forms.TextBox txtSifra;
        public System.Windows.Forms.Label lblImeGreska;
        public System.Windows.Forms.Label lblSifraGreska;
    }
}