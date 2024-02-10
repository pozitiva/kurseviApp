namespace Klijent.KorisnickeKontrole
{
    partial class UcPrikaziGrupe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelektovanaGrupaGreska = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.lblGrupe = new System.Windows.Forms.Label();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelektovanaGrupaGreska
            // 
            this.lblSelektovanaGrupaGreska.AutoSize = true;
            this.lblSelektovanaGrupaGreska.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelektovanaGrupaGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSelektovanaGrupaGreska.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelektovanaGrupaGreska.Location = new System.Drawing.Point(64, 584);
            this.lblSelektovanaGrupaGreska.Name = "lblSelektovanaGrupaGreska";
            this.lblSelektovanaGrupaGreska.Size = new System.Drawing.Size(61, 20);
            this.lblSelektovanaGrupaGreska.TabIndex = 40;
            this.lblSelektovanaGrupaGreska.Text = "Greska";
            this.lblSelektovanaGrupaGreska.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFilter.Location = new System.Drawing.Point(58, 548);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(327, 30);
            this.txtFilter.TabIndex = 39;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrikaziSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnPrikaziSve.FlatAppearance.BorderSize = 0;
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrikaziSve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikaziSve.Location = new System.Drawing.Point(725, 548);
            this.btnPrikaziSve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(146, 64);
            this.btnPrikaziSve.TabIndex = 37;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzaberi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnIzaberi.FlatAppearance.BorderSize = 0;
            this.btnIzaberi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIzaberi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzaberi.Location = new System.Drawing.Point(909, 548);
            this.btnIzaberi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(146, 64);
            this.btnIzaberi.TabIndex = 38;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            // 
            // lblGrupe
            // 
            this.lblGrupe.AutoSize = true;
            this.lblGrupe.BackColor = System.Drawing.SystemColors.Control;
            this.lblGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblGrupe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGrupe.Location = new System.Drawing.Point(477, 52);
            this.lblGrupe.Name = "lblGrupe";
            this.lblGrupe.Size = new System.Drawing.Size(130, 46);
            this.lblGrupe.TabIndex = 35;
            this.lblGrupe.Text = "Grupe";
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(58, 126);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.RowHeadersWidth = 62;
            this.dgvGrupe.RowTemplate.Height = 28;
            this.dgvGrupe.Size = new System.Drawing.Size(997, 415);
            this.dgvGrupe.TabIndex = 41;
            // 
            // UcPrikaziGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvGrupe);
            this.Controls.Add(this.lblSelektovanaGrupaGreska);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.lblGrupe);
            this.Name = "UcPrikaziGrupe";
            this.Size = new System.Drawing.Size(1115, 938);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSelektovanaGrupaGreska;
        public System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.Button btnPrikaziSve;
        public System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Label lblGrupe;
        public System.Windows.Forms.DataGridView dgvGrupe;
    }
}
