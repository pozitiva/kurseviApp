﻿namespace Klijent.KorisnickeKontrole
{
    partial class UcPrikaziKurseve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelektovanUcenikGreska = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnPrikaziSveKurseve = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.lblKursevi = new System.Windows.Forms.Label();
            this.btnIzmeniKurs = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelektovanUcenikGreska
            // 
            this.lblSelektovanUcenikGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelektovanUcenikGreska.AutoSize = true;
            this.lblSelektovanUcenikGreska.BackColor = System.Drawing.Color.Transparent;
            this.lblSelektovanUcenikGreska.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
            this.lblSelektovanUcenikGreska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.lblSelektovanUcenikGreska.Location = new System.Drawing.Point(72, 564);
            this.lblSelektovanUcenikGreska.Name = "lblSelektovanUcenikGreska";
            this.lblSelektovanUcenikGreska.Size = new System.Drawing.Size(60, 19);
            this.lblSelektovanUcenikGreska.TabIndex = 32;
            this.lblSelektovanUcenikGreska.Text = "Greska";
            this.lblSelektovanUcenikGreska.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.BackColor = System.Drawing.Color.SeaShell;
            this.txtFilter.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.txtFilter.Location = new System.Drawing.Point(66, 528);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(327, 32);
            this.txtFilter.TabIndex = 31;
            // 
            // btnPrikaziSveKurseve
            // 
            this.btnPrikaziSveKurseve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziSveKurseve.BackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziSveKurseve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSveKurseve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnPrikaziSveKurseve.FlatAppearance.BorderSize = 0;
            this.btnPrikaziSveKurseve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziSveKurseve.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSveKurseve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnPrikaziSveKurseve.Location = new System.Drawing.Point(753, 528);
            this.btnPrikaziSveKurseve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrikaziSveKurseve.Name = "btnPrikaziSveKurseve";
            this.btnPrikaziSveKurseve.Size = new System.Drawing.Size(146, 64);
            this.btnPrikaziSveKurseve.TabIndex = 29;
            this.btnPrikaziSveKurseve.Text = "Prikaži sve";
            this.btnPrikaziSveKurseve.UseVisualStyleBackColor = false;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzaberi.BackColor = System.Drawing.Color.Transparent;
            this.btnIzaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzaberi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnIzaberi.FlatAppearance.BorderSize = 0;
            this.btnIzaberi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzaberi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzaberi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnIzaberi.Location = new System.Drawing.Point(917, 528);
            this.btnIzaberi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(146, 64);
            this.btnIzaberi.TabIndex = 30;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKursevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKursevi.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvKursevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKursevi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKursevi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKursevi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKursevi.ColumnHeadersHeight = 40;
            this.dgvKursevi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKursevi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKursevi.EnableHeadersVisualStyles = false;
            this.dgvKursevi.Location = new System.Drawing.Point(66, 105);
            this.dgvKursevi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKursevi.MultiSelect = false;
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.RowHeadersVisible = false;
            this.dgvKursevi.RowHeadersWidth = 51;
            this.dgvKursevi.RowTemplate.Height = 35;
            this.dgvKursevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKursevi.Size = new System.Drawing.Size(997, 415);
            this.dgvKursevi.TabIndex = 28;
            // 
            // lblKursevi
            // 
            this.lblKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKursevi.AutoSize = true;
            this.lblKursevi.BackColor = System.Drawing.Color.Transparent;
            this.lblKursevi.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKursevi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.lblKursevi.Location = new System.Drawing.Point(478, 27);
            this.lblKursevi.Name = "lblKursevi";
            this.lblKursevi.Size = new System.Drawing.Size(176, 54);
            this.lblKursevi.TabIndex = 27;
            this.lblKursevi.Text = "Kursevi";
            // 
            // btnIzmeniKurs
            // 
            this.btnIzmeniKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniKurs.BackColor = System.Drawing.Color.Transparent;
            this.btnIzmeniKurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeniKurs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnIzmeniKurs.FlatAppearance.BorderSize = 0;
            this.btnIzmeniKurs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniKurs.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniKurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnIzmeniKurs.Location = new System.Drawing.Point(917, 528);
            this.btnIzmeniKurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmeniKurs.Name = "btnIzmeniKurs";
            this.btnIzmeniKurs.Size = new System.Drawing.Size(146, 64);
            this.btnIzmeniKurs.TabIndex = 33;
            this.btnIzmeniKurs.Text = "Izmeni";
            this.btnIzmeniKurs.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnObrisi.Location = new System.Drawing.Point(917, 528);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(146, 64);
            this.btnObrisi.TabIndex = 34;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // UcPrikaziKurseve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeniKurs);
            this.Controls.Add(this.lblSelektovanUcenikGreska);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPrikaziSveKurseve);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvKursevi);
            this.Controls.Add(this.lblKursevi);
            this.Name = "UcPrikaziKurseve";
            this.Size = new System.Drawing.Size(1145, 659);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKursevi;
        public System.Windows.Forms.Label lblSelektovanUcenikGreska;
        public System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.Button btnPrikaziSveKurseve;
        public System.Windows.Forms.Button btnIzaberi;
        public System.Windows.Forms.DataGridView dgvKursevi;
        public System.Windows.Forms.Button btnIzmeniKurs;
        public System.Windows.Forms.Button btnObrisi;
    }
}