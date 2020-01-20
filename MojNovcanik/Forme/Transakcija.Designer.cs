﻿namespace MojNovcanik.Forme
{
    partial class Transakcija
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkPonavljanje = new System.Windows.Forms.CheckBox();
            this.datumPonavljanja = new System.Windows.Forms.DateTimePicker();
            this.checkRashod = new System.Windows.Forms.RadioButton();
            this.checkPrihod = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDodajKategoriju = new System.Windows.Forms.TextBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnZapamtiTransakciju = new System.Windows.Forms.Button();
            this.txtIznosTransakcije = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznos Transkacije:";
            // 
            // checkPonavljanje
            // 
            this.checkPonavljanje.AutoSize = true;
            this.checkPonavljanje.Location = new System.Drawing.Point(62, 99);
            this.checkPonavljanje.Name = "checkPonavljanje";
            this.checkPonavljanje.Size = new System.Drawing.Size(81, 17);
            this.checkPonavljanje.TabIndex = 1;
            this.checkPonavljanje.Text = "Ponavljanje";
            this.checkPonavljanje.UseVisualStyleBackColor = true;
            // 
            // datumPonavljanja
            // 
            this.datumPonavljanja.CustomFormat = "MM/DD/";
            this.datumPonavljanja.Location = new System.Drawing.Point(62, 147);
            this.datumPonavljanja.Name = "datumPonavljanja";
            this.datumPonavljanja.Size = new System.Drawing.Size(200, 20);
            this.datumPonavljanja.TabIndex = 2;
            // 
            // checkRashod
            // 
            this.checkRashod.AutoSize = true;
            this.checkRashod.Location = new System.Drawing.Point(15, 42);
            this.checkRashod.Name = "checkRashod";
            this.checkRashod.Size = new System.Drawing.Size(62, 17);
            this.checkRashod.TabIndex = 3;
            this.checkRashod.Text = "Rashod";
            this.checkRashod.UseVisualStyleBackColor = true;
            // 
            // checkPrihod
            // 
            this.checkPrihod.AutoSize = true;
            this.checkPrihod.Checked = true;
            this.checkPrihod.Location = new System.Drawing.Point(15, 19);
            this.checkPrihod.Name = "checkPrihod";
            this.checkPrihod.Size = new System.Drawing.Size(55, 17);
            this.checkPrihod.TabIndex = 4;
            this.checkPrihod.TabStop = true;
            this.checkPrihod.Text = "Prihod";
            this.checkPrihod.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrihod);
            this.groupBox1.Controls.Add(this.checkRashod);
            this.groupBox1.Location = new System.Drawing.Point(62, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta Transakcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv Kategorije:";
            // 
            // txtDodajKategoriju
            // 
            this.txtDodajKategoriju.Location = new System.Drawing.Point(560, 49);
            this.txtDodajKategoriju.Name = "txtDodajKategoriju";
            this.txtDodajKategoriju.Size = new System.Drawing.Size(100, 20);
            this.txtDodajKategoriju.TabIndex = 7;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(470, 99);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(113, 23);
            this.btnDodajKategoriju.TabIndex = 8;
            this.btnDodajKategoriju.Text = "Dodaj Kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(62, 340);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 9;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // btnZapamtiTransakciju
            // 
            this.btnZapamtiTransakciju.Location = new System.Drawing.Point(62, 395);
            this.btnZapamtiTransakciju.Name = "btnZapamtiTransakciju";
            this.btnZapamtiTransakciju.Size = new System.Drawing.Size(121, 23);
            this.btnZapamtiTransakciju.TabIndex = 10;
            this.btnZapamtiTransakciju.Text = "Zapamti transakciju";
            this.btnZapamtiTransakciju.UseVisualStyleBackColor = true;
            this.btnZapamtiTransakciju.Click += new System.EventHandler(this.btnZapamtiTransakciju_Click);
            // 
            // txtIznosTransakcije
            // 
            this.txtIznosTransakcije.Location = new System.Drawing.Point(162, 52);
            this.txtIznosTransakcije.Name = "txtIznosTransakcije";
            this.txtIznosTransakcije.Size = new System.Drawing.Size(100, 20);
            this.txtIznosTransakcije.TabIndex = 11;
            // 
            // Transakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIznosTransakcije);
            this.Controls.Add(this.btnZapamtiTransakciju);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.txtDodajKategoriju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datumPonavljanja);
            this.Controls.Add(this.checkPonavljanje);
            this.Controls.Add(this.label1);
            this.Name = "Transakcija";
            this.Text = "Transakcija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPonavljanje;
        private System.Windows.Forms.DateTimePicker datumPonavljanja;
        private System.Windows.Forms.RadioButton checkRashod;
        private System.Windows.Forms.RadioButton checkPrihod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDodajKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnZapamtiTransakciju;
        private System.Windows.Forms.TextBox txtIznosTransakcije;
    }
}