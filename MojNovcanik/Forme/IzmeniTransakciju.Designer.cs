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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Transakcije:";
            // 
            // cmbTransakcijeID
            // 
            this.cmbTransakcijeID.FormattingEnabled = true;
            this.cmbTransakcijeID.Location = new System.Drawing.Point(185, 44);
            this.cmbTransakcijeID.Name = "cmbTransakcijeID";
            this.cmbTransakcijeID.Size = new System.Drawing.Size(121, 21);
            this.cmbTransakcijeID.TabIndex = 1;
            this.cmbTransakcijeID.SelectedIndexChanged += new System.EventHandler(this.cmbTransakcijeID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ponavljanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vreme ponavljanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 305);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtIznosTransakcije
            // 
            this.txtIznosTransakcije.Location = new System.Drawing.Point(185, 82);
            this.txtIznosTransakcije.Name = "txtIznosTransakcije";
            this.txtIznosTransakcije.Size = new System.Drawing.Size(100, 20);
            this.txtIznosTransakcije.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrihod);
            this.groupBox1.Controls.Add(this.checkRashod);
            this.groupBox1.Location = new System.Drawing.Point(90, 131);
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
            this.checkPrihod.Location = new System.Drawing.Point(15, 19);
            this.checkPrihod.Name = "checkPrihod";
            this.checkPrihod.Size = new System.Drawing.Size(55, 17);
            this.checkPrihod.TabIndex = 4;
            this.checkPrihod.TabStop = true;
            this.checkPrihod.Text = "Prihod";
            this.checkPrihod.UseVisualStyleBackColor = true;
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
            // checkBoxPonavljanje
            // 
            this.checkBoxPonavljanje.AutoSize = true;
            this.checkBoxPonavljanje.Location = new System.Drawing.Point(165, 257);
            this.checkBoxPonavljanje.Name = "checkBoxPonavljanje";
            this.checkBoxPonavljanje.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPonavljanje.TabIndex = 9;
            this.checkBoxPonavljanje.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(164, 369);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 11;
            // 
            // IzmeniTransakciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}