namespace MojNovcanik.Forme
{
    partial class IzmeniTransakciju
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
            this.cmbTransakcijeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIznosTransakcije = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkPrihod = new System.Windows.Forms.RadioButton();
            this.checkRashod = new System.Windows.Forms.RadioButton();
            this.checkBoxPonavljanje = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Transakcije:";
            // 
            // cmbTransakcijeID
            // 
            this.cmbTransakcijeID.FormattingEnabled = true;
            this.cmbTransakcijeID.Location = new System.Drawing.Point(137, 76);
            this.cmbTransakcijeID.Name = "cmbTransakcijeID";
            this.cmbTransakcijeID.Size = new System.Drawing.Size(121, 21);
            this.cmbTransakcijeID.TabIndex = 1;
            this.cmbTransakcijeID.SelectedIndexChanged += new System.EventHandler(this.cmbTransakcijeID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ponavljanje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vreme ponavljanja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtIznosTransakcije
            // 
            this.txtIznosTransakcije.Location = new System.Drawing.Point(137, 113);
            this.txtIznosTransakcije.Name = "txtIznosTransakcije";
            this.txtIznosTransakcije.Size = new System.Drawing.Size(100, 20);
            this.txtIznosTransakcije.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrihod);
            this.groupBox1.Controls.Add(this.checkRashod);
            this.groupBox1.Location = new System.Drawing.Point(357, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta Transakcije";
            // 
            // checkPrihod
            // 
            this.checkPrihod.AutoSize = true;
            this.checkPrihod.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
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
            // checkBoxPonavljanje
            // 
            this.checkBoxPonavljanje.AutoSize = true;
            this.checkBoxPonavljanje.Location = new System.Drawing.Point(125, 172);
            this.checkBoxPonavljanje.Name = "checkBoxPonavljanje";
            this.checkBoxPonavljanje.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPonavljanje.TabIndex = 9;
            this.checkBoxPonavljanje.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kategorija:";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategorija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(436, 206);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 11;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(482, 257);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Izmena transakcije";
            // 
            // IzmeniTransakciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxPonavljanje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIznosTransakcije);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTransakcijeID);
            this.Controls.Add(this.label1);
            this.Name = "IzmeniTransakciju";
            this.Text = "IzmeniTransakciju";
            this.Load += new System.EventHandler(this.IzmeniTransakciju_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransakcijeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIznosTransakcije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkPrihod;
        private System.Windows.Forms.RadioButton checkRashod;
        private System.Windows.Forms.CheckBox checkBoxPonavljanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label6;
    }
}