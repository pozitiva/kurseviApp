namespace kurseviApp
{
    partial class FrmServer
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnPrekini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.SeaShell;
            this.btnPokreni.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.btnPokreni.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPokreni.Location = new System.Drawing.Point(157, 92);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(170, 73);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnPrekini
            // 
            this.btnPrekini.BackColor = System.Drawing.Color.SeaShell;
            this.btnPrekini.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.btnPrekini.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPrekini.Location = new System.Drawing.Point(157, 250);
            this.btnPrekini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrekini.Name = "btnPrekini";
            this.btnPrekini.Size = new System.Drawing.Size(170, 73);
            this.btnPrekini.TabIndex = 1;
            this.btnPrekini.Text = "Prekini server";
            this.btnPrekini.UseVisualStyleBackColor = false;
            this.btnPrekini.Click += new System.EventHandler(this.btnPrekini_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(506, 460);
            this.Controls.Add(this.btnPrekini);
            this.Controls.Add(this.btnPokreni);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnPrekini;
    }
}

