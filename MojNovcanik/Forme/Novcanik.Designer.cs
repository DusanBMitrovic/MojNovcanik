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
            this.btnDodajTransakciju = new System.Windows.Forms.Button();
            this.btnRefreshTransakcije = new System.Windows.Forms.Button();
            this.moj_novcanikDataSet = new MojNovcanik.moj_novcanikDataSet();
            this.kategorijatransakcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija_transakcijeTableAdapter = new MojNovcanik.moj_novcanikDataSetTableAdapters.kategorija_transakcijeTableAdapter();
            this.mojnovcanikDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponavljanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremePonavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzmeniTransakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moj_novcanikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijatransakcijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojnovcanikDataSetBindingSource)).BeginInit();
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
            // lblBilans
            // 
            this.lblBilans.AutoSize = true;
            this.lblBilans.Location = new System.Drawing.Point(73, 77);
            this.lblBilans.Name = "lblBilans";
            this.lblBilans.Size = new System.Drawing.Size(35, 13);
            this.lblBilans.TabIndex = 5;
            this.lblBilans.Text = "Bilans";
            // 
            // lblBilansNovcanika
            // 
            this.lblBilansNovcanika.AutoSize = true;
            this.lblBilansNovcanika.Location = new System.Drawing.Point(134, 77);
            this.lblBilansNovcanika.Name = "lblBilansNovcanika";
            this.lblBilansNovcanika.Size = new System.Drawing.Size(0, 13);
            this.lblBilansNovcanika.TabIndex = 6;
            // 
            // dataGridTransakcije
            // 
            this.dataGridTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransakcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.datum,
            this.iznos,
            this.vrsta,
            this.ponavljanje,
            this.vremePonavljanja});
            this.dataGridTransakcije.Location = new System.Drawing.Point(150, 148);
            this.dataGridTransakcije.Name = "dataGridTransakcije";
            this.dataGridTransakcije.Size = new System.Drawing.Size(544, 221);
            this.dataGridTransakcije.TabIndex = 7;
            // 
            // btnDodajTransakciju
            // 
            this.btnDodajTransakciju.Location = new System.Drawing.Point(438, 104);
            this.btnDodajTransakciju.Name = "btnDodajTransakciju";
            this.btnDodajTransakciju.Size = new System.Drawing.Size(131, 23);
            this.btnDodajTransakciju.TabIndex = 8;
            this.btnDodajTransakciju.Text = "Dodaj Transakciju";
            this.btnDodajTransakciju.UseVisualStyleBackColor = true;
            this.btnDodajTransakciju.Click += new System.EventHandler(this.btnDodajTransakciju_Click);
            // 
            // btnRefreshTransakcije
            // 
            this.btnRefreshTransakcije.Location = new System.Drawing.Point(45, 148);
            this.btnRefreshTransakcije.Name = "btnRefreshTransakcije";
            this.btnRefreshTransakcije.Size = new System.Drawing.Size(75, 23);
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
            // btnIzmeniTransakciju
            // 
            this.btnIzmeniTransakciju.Location = new System.Drawing.Point(262, 104);
            this.btnIzmeniTransakciju.Name = "btnIzmeniTransakciju";
            this.btnIzmeniTransakciju.Size = new System.Drawing.Size(131, 23);
            this.btnIzmeniTransakciju.TabIndex = 10;
            this.btnIzmeniTransakciju.Text = "Izmeni Transakciju";
            this.btnIzmeniTransakciju.UseVisualStyleBackColor = true;
            this.btnIzmeniTransakciju.Click += new System.EventHandler(this.btnIzmeniTransakciju_Click);
            // 
            // Novcanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmeniTransakciju);
            this.Controls.Add(this.btnRefreshTransakcije);
            this.Controls.Add(this.btnDodajTransakciju);
            this.Controls.Add(this.dataGridTransakcije);
            this.Controls.Add(this.lblBilansNovcanika);
            this.Controls.Add(this.lblBilans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoviNovcanik);
            this.Controls.Add(this.btnDodajNovacnik);
            this.Controls.Add(this.cmbNovcanik);
            this.Controls.Add(this.label1);
            this.Name = "Novcanik";
            this.Text = "Novcanik";
            this.Load += new System.EventHandler(this.Novcanik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moj_novcanikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijatransakcijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojnovcanikDataSetBindingSource)).EndInit();
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
    }
}