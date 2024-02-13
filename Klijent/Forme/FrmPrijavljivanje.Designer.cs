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
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.SeaShell;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.Firebrick;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(226, 67);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(164, 32);
            this.txtKorisnickoIme.TabIndex = 0;
            // 
            // txtSifra
            // 
            this.txtSifra.BackColor = System.Drawing.Color.SeaShell;
            this.txtSifra.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.txtSifra.ForeColor = System.Drawing.Color.Firebrick;
            this.txtSifra.Location = new System.Drawing.Point(226, 132);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(164, 32);
            this.txtSifra.TabIndex = 1;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.SeaShell;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPrijaviSe.Location = new System.Drawing.Point(136, 246);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(164, 40);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifra";
            // 
            // lblImeGreska
            // 
            this.lblImeGreska.AutoSize = true;
            this.lblImeGreska.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.lblImeGreska.ForeColor = System.Drawing.Color.Firebrick;
            this.lblImeGreska.Location = new System.Drawing.Point(221, 102);
            this.lblImeGreska.Name = "lblImeGreska";
            this.lblImeGreska.Size = new System.Drawing.Size(79, 25);
            this.lblImeGreska.TabIndex = 5;
            this.lblImeGreska.Text = "Greska";
            this.lblImeGreska.Visible = false;
            // 
            // lblSifraGreska
            // 
            this.lblSifraGreska.AutoSize = true;
            this.lblSifraGreska.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.lblSifraGreska.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSifraGreska.Location = new System.Drawing.Point(222, 167);
            this.lblSifraGreska.Name = "lblSifraGreska";
            this.lblSifraGreska.Size = new System.Drawing.Size(79, 25);
            this.lblSifraGreska.TabIndex = 6;
            this.lblSifraGreska.Text = "Greska";
            this.lblSifraGreska.Visible = false;
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(558, 374);
            this.Controls.Add(this.lblSifraGreska);
            this.Controls.Add(this.lblImeGreska);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Name = "FrmPrijavljivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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