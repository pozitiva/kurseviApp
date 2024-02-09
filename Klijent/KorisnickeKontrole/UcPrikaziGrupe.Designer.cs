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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelektovanaGrupaGreska = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.lblGrupe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelektovanaGrupaGreska
            // 
            this.lblSelektovanaGrupaGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelektovanaGrupaGreska.AutoSize = true;
            this.lblSelektovanaGrupaGreska.BackColor = System.Drawing.Color.Transparent;
            this.lblSelektovanaGrupaGreska.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
            this.lblSelektovanaGrupaGreska.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelektovanaGrupaGreska.Location = new System.Drawing.Point(64, 584);
            this.lblSelektovanaGrupaGreska.Name = "lblSelektovanaGrupaGreska";
            this.lblSelektovanaGrupaGreska.Size = new System.Drawing.Size(60, 19);
            this.lblSelektovanaGrupaGreska.TabIndex = 40;
            this.lblSelektovanaGrupaGreska.Text = "Greska";
            this.lblSelektovanaGrupaGreska.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilter.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.txtFilter.Location = new System.Drawing.Point(58, 548);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(327, 32);
            this.txtFilter.TabIndex = 39;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziSve.BackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnPrikaziSve.FlatAppearance.BorderSize = 0;
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrikaziSve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikaziSve.Location = new System.Drawing.Point(909, 548);
            this.btnPrikaziSve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(146, 64);
            this.btnPrikaziSve.TabIndex = 37;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzaberi.BackColor = System.Drawing.Color.Transparent;
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
            // dgvGrupe
            // 
            this.dgvGrupe.AllowUserToAddRows = false;
            this.dgvGrupe.AllowUserToDeleteRows = false;
            this.dgvGrupe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGrupe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGrupe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrupe.ColumnHeadersHeight = 40;
            this.dgvGrupe.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrupe.EnableHeadersVisualStyles = false;
            this.dgvGrupe.Location = new System.Drawing.Point(58, 125);
            this.dgvGrupe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGrupe.MultiSelect = false;
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.RowHeadersVisible = false;
            this.dgvGrupe.RowHeadersWidth = 51;
            this.dgvGrupe.RowTemplate.Height = 35;
            this.dgvGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupe.Size = new System.Drawing.Size(997, 415);
            this.dgvGrupe.TabIndex = 36;
            // 
            // lblGrupe
            // 
            this.lblGrupe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrupe.AutoSize = true;
            this.lblGrupe.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblGrupe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGrupe.Location = new System.Drawing.Point(478, 47);
            this.lblGrupe.Name = "lblGrupe";
            this.lblGrupe.Size = new System.Drawing.Size(130, 46);
            this.lblGrupe.TabIndex = 35;
            this.lblGrupe.Text = "Grupe";
            // 
            // UcPrikaziGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelektovanaGrupaGreska);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvGrupe);
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
        public System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.Label lblGrupe;
    }
}
