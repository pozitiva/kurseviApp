namespace Klijent.Forme
{
    partial class FrmZaposleni
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
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.msZaposleni = new System.Windows.Forms.MenuStrip();
            this.kurseviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKursevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.msZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.BackColor = System.Drawing.Color.MistyRose;
            this.lblZaposleni.ForeColor = System.Drawing.Color.Firebrick;
            this.lblZaposleni.Location = new System.Drawing.Point(785, 2);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(100, 23);
            this.lblZaposleni.TabIndex = 0;
            // 
            // msZaposleni
            // 
            this.msZaposleni.BackColor = System.Drawing.Color.MistyRose;
            this.msZaposleni.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.msZaposleni.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msZaposleni.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurseviToolStripMenuItem,
            this.ucenikToolStripMenuItem,
            this.grupaToolStripMenuItem});
            this.msZaposleni.Location = new System.Drawing.Point(0, 0);
            this.msZaposleni.Name = "msZaposleni";
            this.msZaposleni.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.msZaposleni.Size = new System.Drawing.Size(926, 37);
            this.msZaposleni.TabIndex = 1;
            this.msZaposleni.Text = "menuStrip1";
            // 
            // kurseviToolStripMenuItem
            // 
            this.kurseviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajKursToolStripMenuItem,
            this.izmeniKursToolStripMenuItem,
            this.pretragaKursevaToolStripMenuItem,
            this.obrisiKursToolStripMenuItem});
            this.kurseviToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            this.kurseviToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.kurseviToolStripMenuItem.Text = "Kursevi";
            // 
            // kreirajKursToolStripMenuItem
            // 
            this.kreirajKursToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.kreirajKursToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.kreirajKursToolStripMenuItem.Name = "kreirajKursToolStripMenuItem";
            this.kreirajKursToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.kreirajKursToolStripMenuItem.Text = "Kreiraj kurs";
            // 
            // izmeniKursToolStripMenuItem
            // 
            this.izmeniKursToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.izmeniKursToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.izmeniKursToolStripMenuItem.Name = "izmeniKursToolStripMenuItem";
            this.izmeniKursToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.izmeniKursToolStripMenuItem.Text = "Izmeni kurs";
            // 
            // pretragaKursevaToolStripMenuItem
            // 
            this.pretragaKursevaToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.pretragaKursevaToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.pretragaKursevaToolStripMenuItem.Name = "pretragaKursevaToolStripMenuItem";
            this.pretragaKursevaToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.pretragaKursevaToolStripMenuItem.Text = "Pretraga kurseva";
            // 
            // obrisiKursToolStripMenuItem
            // 
            this.obrisiKursToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.obrisiKursToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.obrisiKursToolStripMenuItem.Name = "obrisiKursToolStripMenuItem";
            this.obrisiKursToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.obrisiKursToolStripMenuItem.Text = "Obrisi kurs";
            // 
            // ucenikToolStripMenuItem
            // 
            this.ucenikToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.ucenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajUcenikaToolStripMenuItem,
            this.izmeniUcenikaToolStripMenuItem,
            this.obrisiUcenikaToolStripMenuItem});
            this.ucenikToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.ucenikToolStripMenuItem.Name = "ucenikToolStripMenuItem";
            this.ucenikToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.ucenikToolStripMenuItem.Text = "Ucenik";
            // 
            // kreirajUcenikaToolStripMenuItem
            // 
            this.kreirajUcenikaToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.kreirajUcenikaToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.kreirajUcenikaToolStripMenuItem.Name = "kreirajUcenikaToolStripMenuItem";
            this.kreirajUcenikaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.kreirajUcenikaToolStripMenuItem.Text = "Kreiraj ucenika";
            // 
            // izmeniUcenikaToolStripMenuItem
            // 
            this.izmeniUcenikaToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.izmeniUcenikaToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.izmeniUcenikaToolStripMenuItem.Name = "izmeniUcenikaToolStripMenuItem";
            this.izmeniUcenikaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.izmeniUcenikaToolStripMenuItem.Text = "Izmeni ucenika";
            // 
            // obrisiUcenikaToolStripMenuItem
            // 
            this.obrisiUcenikaToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.obrisiUcenikaToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.obrisiUcenikaToolStripMenuItem.Name = "obrisiUcenikaToolStripMenuItem";
            this.obrisiUcenikaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.obrisiUcenikaToolStripMenuItem.Text = "Obrisi ucenika";
            // 
            // grupaToolStripMenuItem
            // 
            this.grupaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajGrupuToolStripMenuItem,
            this.izmeniGrupuToolStripMenuItem});
            this.grupaToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.grupaToolStripMenuItem.Name = "grupaToolStripMenuItem";
            this.grupaToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.grupaToolStripMenuItem.Text = "Grupa";
            // 
            // kreirajGrupuToolStripMenuItem
            // 
            this.kreirajGrupuToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.kreirajGrupuToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.kreirajGrupuToolStripMenuItem.Name = "kreirajGrupuToolStripMenuItem";
            this.kreirajGrupuToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.kreirajGrupuToolStripMenuItem.Text = "Kreiraj grupu";
            // 
            // izmeniGrupuToolStripMenuItem
            // 
            this.izmeniGrupuToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.izmeniGrupuToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.izmeniGrupuToolStripMenuItem.Name = "izmeniGrupuToolStripMenuItem";
            this.izmeniGrupuToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.izmeniGrupuToolStripMenuItem.Text = "Izmeni grupu";
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGlavna.AutoScroll = true;
            this.pnlGlavna.AutoSize = true;
            this.pnlGlavna.BackColor = System.Drawing.Color.MistyRose;
            this.pnlGlavna.ForeColor = System.Drawing.Color.Maroon;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 29);
            this.pnlGlavna.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(926, 489);
            this.pnlGlavna.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(572, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulogovani zaposleni";
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblZaposleni);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.msZaposleni);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposleni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel zaposlenog";
            this.msZaposleni.ResumeLayout(false);
            this.msZaposleni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.MenuStrip msZaposleni;
        private System.Windows.Forms.ToolStripMenuItem kurseviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKursToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavna;
        private System.Windows.Forms.ToolStripMenuItem pretragaKursevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajUcenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUcenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiUcenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniGrupuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}