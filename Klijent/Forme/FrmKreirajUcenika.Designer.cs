namespace Klijent.Forme
{
    partial class FrmKreirajUcenika
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
            this.pnlKreirajUcenika = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlKreirajUcenika
            // 
            this.pnlKreirajUcenika.Location = new System.Drawing.Point(4, 25);
            this.pnlKreirajUcenika.Name = "pnlKreirajUcenika";
            this.pnlKreirajUcenika.Size = new System.Drawing.Size(926, 489);
            this.pnlKreirajUcenika.TabIndex = 0;
            // 
            // FrmKreirajUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(926, 518);
            this.Controls.Add(this.pnlKreirajUcenika);
            this.Name = "FrmKreirajUcenika";
            this.Text = "Kreiraj ucenika";
            this.Load += new System.EventHandler(this.FrmKreirajUcenika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKreirajUcenika;
    }
}