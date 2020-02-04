namespace MojNovcanik.Forme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKategorijaArhiviranje = new System.Windows.Forms.ComboBox();
            this.btnArhivirajKategoriju = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznos Transkacije:";
            // 
            // checkPonavljanje
            // 
            this.checkPonavljanje.AutoSize = true;
            this.checkPonavljanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPonavljanje.Location = new System.Drawing.Point(9, 81);
            this.checkPonavljanje.Name = "checkPonavljanje";
            this.checkPonavljanje.Size = new System.Drawing.Size(100, 21);
            this.checkPonavljanje.TabIndex = 1;
            this.checkPonavljanje.Text = "Ponavljanje";
            this.checkPonavljanje.UseVisualStyleBackColor = true;
            // 
            // datumPonavljanja
            // 
            this.datumPonavljanja.CustomFormat = "MM/DD/";
            this.datumPonavljanja.Location = new System.Drawing.Point(9, 129);
            this.datumPonavljanja.Name = "datumPonavljanja";
            this.datumPonavljanja.Size = new System.Drawing.Size(200, 20);
            this.datumPonavljanja.TabIndex = 2;
            // 
            // checkRashod
            // 
            this.checkRashod.AutoSize = true;
            this.checkRashod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRashod.Location = new System.Drawing.Point(15, 42);
            this.checkRashod.Name = "checkRashod";
            this.checkRashod.Size = new System.Drawing.Size(75, 21);
            this.checkRashod.TabIndex = 3;
            this.checkRashod.Text = "Rashod";
            this.checkRashod.UseVisualStyleBackColor = true;
            // 
            // checkPrihod
            // 
            this.checkPrihod.AutoSize = true;
            this.checkPrihod.Checked = true;
            this.checkPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrihod.Location = new System.Drawing.Point(15, 19);
            this.checkPrihod.Name = "checkPrihod";
            this.checkPrihod.Size = new System.Drawing.Size(67, 21);
            this.checkPrihod.TabIndex = 4;
            this.checkPrihod.TabStop = true;
            this.checkPrihod.Text = "Prihod";
            this.checkPrihod.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrihod);
            this.groupBox1.Controls.Add(this.checkRashod);
            this.groupBox1.Location = new System.Drawing.Point(9, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta Transakcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv Kategorije:";
            // 
            // txtDodajKategoriju
            // 
            this.txtDodajKategoriju.Location = new System.Drawing.Point(138, 33);
            this.txtDodajKategoriju.Name = "txtDodajKategoriju";
            this.txtDodajKategoriju.Size = new System.Drawing.Size(100, 20);
            this.txtDodajKategoriju.TabIndex = 7;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(125, 77);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(113, 23);
            this.btnDodajKategoriju.TabIndex = 8;
            this.btnDodajKategoriju.Text = "Dodaj Kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategorija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(88, 322);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.Sorted = true;
            this.cmbKategorija.TabIndex = 9;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // btnZapamtiTransakciju
            // 
            this.btnZapamtiTransakciju.Location = new System.Drawing.Point(9, 385);
            this.btnZapamtiTransakciju.Name = "btnZapamtiTransakciju";
            this.btnZapamtiTransakciju.Size = new System.Drawing.Size(121, 23);
            this.btnZapamtiTransakciju.TabIndex = 10;
            this.btnZapamtiTransakciju.Text = "Zapamti transakciju";
            this.btnZapamtiTransakciju.UseVisualStyleBackColor = true;
            this.btnZapamtiTransakciju.Click += new System.EventHandler(this.btnZapamtiTransakciju_Click);
            // 
            // txtIznosTransakcije
            // 
            this.txtIznosTransakcije.Location = new System.Drawing.Point(134, 34);
            this.txtIznosTransakcije.Name = "txtIznosTransakcije";
            this.txtIznosTransakcije.Size = new System.Drawing.Size(100, 20);
            this.txtIznosTransakcije.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kategorija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dodavanje nove transakcije";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDodajKategoriju);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDodajKategoriju);
            this.groupBox2.Location = new System.Drawing.Point(379, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkPonavljanje);
            this.groupBox3.Controls.Add(this.datumPonavljanja);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtIznosTransakcije);
            this.groupBox3.Controls.Add(this.cmbKategorija);
            this.groupBox3.Controls.Add(this.btnZapamtiTransakciju);
            this.groupBox3.Location = new System.Drawing.Point(22, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 414);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dodavanje nove kategorije";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Arhiviranje kategorije";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnArhivirajKategoriju);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbKategorijaArhiviranje);
            this.groupBox4.Location = new System.Drawing.Point(379, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 124);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kategorija:";
            // 
            // cmbKategorijaArhiviranje
            // 
            this.cmbKategorijaArhiviranje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategorijaArhiviranje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategorijaArhiviranje.FormattingEnabled = true;
            this.cmbKategorijaArhiviranje.Location = new System.Drawing.Point(98, 33);
            this.cmbKategorijaArhiviranje.Name = "cmbKategorijaArhiviranje";
            this.cmbKategorijaArhiviranje.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorijaArhiviranje.Sorted = true;
            this.cmbKategorijaArhiviranje.TabIndex = 13;
            // 
            // btnArhivirajKategoriju
            // 
            this.btnArhivirajKategoriju.Location = new System.Drawing.Point(106, 83);
            this.btnArhivirajKategoriju.Name = "btnArhivirajKategoriju";
            this.btnArhivirajKategoriju.Size = new System.Drawing.Size(113, 23);
            this.btnArhivirajKategoriju.TabIndex = 9;
            this.btnArhivirajKategoriju.Text = "Arhiviraj Kategoriji";
            this.btnArhivirajKategoriju.UseVisualStyleBackColor = true;
            this.btnArhivirajKategoriju.Click += new System.EventHandler(this.btnArhivirajKategoriju_Click);
            // 
            // Transakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "Transakcija";
            this.Text = "Transakcija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnArhivirajKategoriju;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKategorijaArhiviranje;
    }
}