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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNovcanik = new System.Windows.Forms.ComboBox();
            this.btnDodajNovacnik = new System.Windows.Forms.Button();
            this.txtNoviNovcanik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBilans = new System.Windows.Forms.Label();
            this.lblBilansNovcanika = new System.Windows.Forms.Label();
            this.dataGridTransakcije = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponavljanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremePonavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajTransakciju = new System.Windows.Forms.Button();
            this.btnRefreshTransakcije = new System.Windows.Forms.Button();
            this.moj_novcanikDataSet = new MojNovcanik.moj_novcanikDataSet();
            this.kategorijatransakcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija_transakcijeTableAdapter = new MojNovcanik.moj_novcanikDataSetTableAdapters.kategorija_transakcijeTableAdapter();
            this.mojnovcanikDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzmeniTransakciju = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUlogovaniKorisnik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moj_novcanikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijatransakcijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojnovcanikDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izabrani Novcanik";
            // 
            // cmbNovcanik
            // 
            this.cmbNovcanik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNovcanik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNovcanik.FormattingEnabled = true;
            this.cmbNovcanik.Location = new System.Drawing.Point(148, 26);
            this.cmbNovcanik.Name = "cmbNovcanik";
            this.cmbNovcanik.Size = new System.Drawing.Size(121, 21);
            this.cmbNovcanik.TabIndex = 1;
            this.cmbNovcanik.SelectedIndexChanged += new System.EventHandler(this.cmbNovcanik_SelectedIndexChanged);
            // 
            // btnDodajNovacnik
            // 
            this.btnDodajNovacnik.Location = new System.Drawing.Point(150, 66);
            this.btnDodajNovacnik.Name = "btnDodajNovacnik";
            this.btnDodajNovacnik.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovacnik.TabIndex = 2;
            this.btnDodajNovacnik.Text = "Dodaj Novcanik";
            this.btnDodajNovacnik.UseVisualStyleBackColor = true;
            this.btnDodajNovacnik.Click += new System.EventHandler(this.btnDodajNovacnik_Click);
            // 
            // txtNoviNovcanik
            // 
            this.txtNoviNovcanik.Location = new System.Drawing.Point(125, 22);
            this.txtNoviNovcanik.Name = "txtNoviNovcanik";
            this.txtNoviNovcanik.Size = new System.Drawing.Size(100, 20);
            this.txtNoviNovcanik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv Novcanika";
            // 
            // lblBilans
            // 
            this.lblBilans.AutoSize = true;
            this.lblBilans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilans.Location = new System.Drawing.Point(14, 72);
            this.lblBilans.Name = "lblBilans";
            this.lblBilans.Size = new System.Drawing.Size(50, 17);
            this.lblBilans.TabIndex = 5;
            this.lblBilans.Text = "Bilans:";
            // 
            // lblBilansNovcanika
            // 
            this.lblBilansNovcanika.AutoSize = true;
            this.lblBilansNovcanika.Location = new System.Drawing.Point(126, 125);
            this.lblBilansNovcanika.Name = "lblBilansNovcanika";
            this.lblBilansNovcanika.Size = new System.Drawing.Size(0, 13);
            this.lblBilansNovcanika.TabIndex = 6;
            // 
            // dataGridTransakcije
            // 
            this.dataGridTransakcije.AllowUserToAddRows = false;
            this.dataGridTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransakcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.datum,
            this.iznos,
            this.vrsta,
            this.ponavljanje,
            this.vremePonavljanja});
            this.dataGridTransakcije.Location = new System.Drawing.Point(15, 234);
            this.dataGridTransakcije.Name = "dataGridTransakcije";
            this.dataGridTransakcije.Size = new System.Drawing.Size(640, 221);
            this.dataGridTransakcije.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // iznos
            // 
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            // 
            // vrsta
            // 
            this.vrsta.HeaderText = "Vrsta";
            this.vrsta.Name = "vrsta";
            this.vrsta.ReadOnly = true;
            // 
            // ponavljanje
            // 
            this.ponavljanje.HeaderText = "Ponavljanje";
            this.ponavljanje.Name = "ponavljanje";
            this.ponavljanje.ReadOnly = true;
            // 
            // vremePonavljanja
            // 
            this.vremePonavljanja.HeaderText = "Vreme Ponavljanja";
            this.vremePonavljanja.Name = "vremePonavljanja";
            this.vremePonavljanja.ReadOnly = true;
            // 
            // btnDodajTransakciju
            // 
            this.btnDodajTransakciju.Location = new System.Drawing.Point(661, 234);
            this.btnDodajTransakciju.Name = "btnDodajTransakciju";
            this.btnDodajTransakciju.Size = new System.Drawing.Size(131, 23);
            this.btnDodajTransakciju.TabIndex = 8;
            this.btnDodajTransakciju.Text = "Dodaj Transakciju";
            this.btnDodajTransakciju.UseVisualStyleBackColor = true;
            this.btnDodajTransakciju.Click += new System.EventHandler(this.btnDodajTransakciju_Click);
            // 
            // btnRefreshTransakcije
            // 
            this.btnRefreshTransakcije.Location = new System.Drawing.Point(661, 292);
            this.btnRefreshTransakcije.Name = "btnRefreshTransakcije";
            this.btnRefreshTransakcije.Size = new System.Drawing.Size(131, 23);
            this.btnRefreshTransakcije.TabIndex = 9;
            this.btnRefreshTransakcije.Text = "Refresh";
            this.btnRefreshTransakcije.UseVisualStyleBackColor = true;
            this.btnRefreshTransakcije.Click += new System.EventHandler(this.btnRefreshTransakcije_Click);
            // 
            // moj_novcanikDataSet
            // 
            this.moj_novcanikDataSet.DataSetName = "moj_novcanikDataSet";
            this.moj_novcanikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijatransakcijeBindingSource
            // 
            this.kategorijatransakcijeBindingSource.DataMember = "kategorija_transakcije";
            this.kategorijatransakcijeBindingSource.DataSource = this.moj_novcanikDataSet;
            // 
            // kategorija_transakcijeTableAdapter
            // 
            this.kategorija_transakcijeTableAdapter.ClearBeforeFill = true;
            // 
            // mojnovcanikDataSetBindingSource
            // 
            this.mojnovcanikDataSetBindingSource.DataSource = this.moj_novcanikDataSet;
            this.mojnovcanikDataSetBindingSource.Position = 0;
            // 
            // btnIzmeniTransakciju
            // 
            this.btnIzmeniTransakciju.Location = new System.Drawing.Point(661, 263);
            this.btnIzmeniTransakciju.Name = "btnIzmeniTransakciju";
            this.btnIzmeniTransakciju.Size = new System.Drawing.Size(131, 23);
            this.btnIzmeniTransakciju.TabIndex = 10;
            this.btnIzmeniTransakciju.Text = "Izmeni Transakciju";
            this.btnIzmeniTransakciju.UseVisualStyleBackColor = true;
            this.btnIzmeniTransakciju.Click += new System.EventHandler(this.btnIzmeniTransakciju_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ulogovani korisnik:";
            // 
            // lblUlogovaniKorisnik
            // 
            this.lblUlogovaniKorisnik.AutoSize = true;
            this.lblUlogovaniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlogovaniKorisnik.Location = new System.Drawing.Point(160, 5);
            this.lblUlogovaniKorisnik.Name = "lblUlogovaniKorisnik";
            this.lblUlogovaniKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lblUlogovaniKorisnik.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBilans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNovcanik);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 104);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNoviNovcanik);
            this.groupBox2.Controls.Add(this.btnDodajNovacnik);
            this.groupBox2.Location = new System.Drawing.Point(520, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Napravi novčanik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Transakcije";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(743, 2);
            this.label5.TabIndex = 16;
            // 
            // Novcanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUlogovaniKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzmeniTransakciju);
            this.Controls.Add(this.btnRefreshTransakcije);
            this.Controls.Add(this.btnDodajTransakciju);
            this.Controls.Add(this.dataGridTransakcije);
            this.Controls.Add(this.lblBilansNovcanika);
            this.Name = "Novcanik";
            this.Text = "Novcanik";
            this.Load += new System.EventHandler(this.Novcanik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moj_novcanikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijatransakcijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojnovcanikDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNovcanik;
        private System.Windows.Forms.Button btnDodajNovacnik;
        private System.Windows.Forms.TextBox txtNoviNovcanik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBilans;
        private System.Windows.Forms.Label lblBilansNovcanika;
        private System.Windows.Forms.DataGridView dataGridTransakcije;
        private System.Windows.Forms.Button btnDodajTransakciju;
        private System.Windows.Forms.Button btnRefreshTransakcije;
        private moj_novcanikDataSet moj_novcanikDataSet;
        private System.Windows.Forms.BindingSource kategorijatransakcijeBindingSource;
        private moj_novcanikDataSetTableAdapters.kategorija_transakcijeTableAdapter kategorija_transakcijeTableAdapter;
        private System.Windows.Forms.BindingSource mojnovcanikDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponavljanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremePonavljanja;
        private System.Windows.Forms.Button btnIzmeniTransakciju;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUlogovaniKorisnik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}