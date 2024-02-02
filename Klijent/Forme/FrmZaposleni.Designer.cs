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
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.msZaposleni.SuspendLayout();
            this.pnlGlavna.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Location = new System.Drawing.Point(701, 44);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(0, 20);
            this.lblZaposleni.TabIndex = 0;
            // 
            // msZaposleni
            // 
            this.msZaposleni.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msZaposleni.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurseviToolStripMenuItem});
            this.msZaposleni.Location = new System.Drawing.Point(0, 0);
            this.msZaposleni.Name = "msZaposleni";
            this.msZaposleni.Size = new System.Drawing.Size(1041, 33);
            this.msZaposleni.TabIndex = 1;
            this.msZaposleni.Text = "menuStrip1";
            // 
            // kurseviToolStripMenuItem
            // 
            this.kurseviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajKursToolStripMenuItem,
            this.izmeniKursToolStripMenuItem});
            this.kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            this.kurseviToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.kurseviToolStripMenuItem.Text = "Kursevi";
            // 
            // kreirajKursToolStripMenuItem
            // 
            this.kreirajKursToolStripMenuItem.Name = "kreirajKursToolStripMenuItem";
            this.kreirajKursToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.kreirajKursToolStripMenuItem.Text = "Kreiraj kurs";
            // 
            // izmeniKursToolStripMenuItem
            // 
            this.izmeniKursToolStripMenuItem.Name = "izmeniKursToolStripMenuItem";
            this.izmeniKursToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.izmeniKursToolStripMenuItem.Text = "Izmeni kurs";
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Controls.Add(this.lblZaposleni);
            this.pnlGlavna.Location = new System.Drawing.Point(16, 46);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(1001, 534);
            this.pnlGlavna.TabIndex = 2;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 586);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.msZaposleni);
            this.Name = "FrmZaposleni";
            this.Text = "FrmGlavna";
            this.msZaposleni.ResumeLayout(false);
            this.msZaposleni.PerformLayout();
            this.pnlGlavna.ResumeLayout(false);
            this.pnlGlavna.PerformLayout();
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
    }
}