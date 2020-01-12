namespace MojNovcanik.Forme
{
    partial class Novcanik
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
            this.cmbNovcanik = new System.Windows.Forms.ComboBox();
            this.btnDodajNovacnik = new System.Windows.Forms.Button();
            this.txtNoviNovcanik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBilansNovcanika = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponavljanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vreme_ponavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izabrani Novcanik";
            // 
            // cmbNovcanik
            // 
            this.cmbNovcanik.FormattingEnabled = true;
            this.cmbNovcanik.Location = new System.Drawing.Point(202, 29);
            this.cmbNovcanik.Name = "cmbNovcanik";
            this.cmbNovcanik.Size = new System.Drawing.Size(121, 21);
            this.cmbNovcanik.TabIndex = 1;
            this.cmbNovcanik.SelectedIndexChanged += new System.EventHandler(this.cmbNovcanik_SelectedIndexChanged);
            // 
            // btnDodajNovacnik
            // 
            this.btnDodajNovacnik.Location = new System.Drawing.Point(646, 27);
            this.btnDodajNovacnik.Name = "btnDodajNovacnik";
            this.btnDodajNovacnik.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovacnik.TabIndex = 2;
            this.btnDodajNovacnik.Text = "Dodaj Novcanik";
            this.btnDodajNovacnik.UseVisualStyleBackColor = true;
            this.btnDodajNovacnik.Click += new System.EventHandler(this.btnDodajNovacnik_Click);
            // 
            // txtNoviNovcanik
            // 
            this.txtNoviNovcanik.Location = new System.Drawing.Point(530, 29);
            this.txtNoviNovcanik.Name = "txtNoviNovcanik";
            this.txtNoviNovcanik.Size = new System.Drawing.Size(100, 20);
            this.txtNoviNovcanik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv Novcanika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bilans";
            // 
            // lblBilansNovcanika
            // 
            this.lblBilansNovcanika.AutoSize = true;
            this.lblBilansNovcanika.Location = new System.Drawing.Point(134, 77);
            this.lblBilansNovcanika.Name = "lblBilansNovcanika";
            this.lblBilansNovcanika.Size = new System.Drawing.Size(0, 13);
            this.lblBilansNovcanika.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datum,
            this.iznos,
            this.vrsta,
            this.ponavljanje,
            this.vreme_ponavljanja});
            this.dataGridView1.Location = new System.Drawing.Point(137, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 221);
            this.dataGridView1.TabIndex = 7;
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // iznos
            // 
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
            // 
            // vrsta
            // 
            this.vrsta.HeaderText = "Vrsta";
            this.vrsta.Name = "vrsta";
            // 
            // ponavljanje
            // 
            this.ponavljanje.HeaderText = "ponavljanje";
            this.ponavljanje.Name = "ponavljanje";
            // 
            // vreme_ponavljanja
            // 
            this.vreme_ponavljanja.HeaderText = "Vreme Ponavljanja";
            this.vreme_ponavljanja.Name = "vreme_ponavljanja";
            // 
            // Novcanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBilansNovcanika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoviNovcanik);
            this.Controls.Add(this.btnDodajNovacnik);
            this.Controls.Add(this.cmbNovcanik);
            this.Controls.Add(this.label1);
            this.Name = "Novcanik";
            this.Text = "Novcanik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNovcanik;
        private System.Windows.Forms.Button btnDodajNovacnik;
        private System.Windows.Forms.TextBox txtNoviNovcanik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBilansNovcanika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponavljanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn vreme_ponavljanja;
    }
}