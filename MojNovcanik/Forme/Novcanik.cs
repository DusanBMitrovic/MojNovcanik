using MojNovcanik.Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojNovcanik.Forme
{

    public partial class Novcanik : Form
    {
        int novcanikId = 0;
        string imeKorisnika;
        public Novcanik(string imeKorisnika)
        {
            InitializeComponent();
            this.imeKorisnika = imeKorisnika;


            using (var db = new MojNovcanik_Context())
            {

                cmbNovcanik.Items.Clear();
                var lista = db.novcaniks.ToList();
                foreach (var item in lista)
                {
                    cmbNovcanik.Items.Add(item.naziv);
                }
                cmbNovcanik.SelectedIndex = 0;
            }
        }

        private void btnDodajNovacnik_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNoviNovcanik.Text.Trim()))
            {
                using (var db = new MojNovcanik_Context())
                {
                    if (db.novcaniks.Where(n => n.naziv == txtNoviNovcanik.Text.Trim()).Count() < 1)
                    {
                        try
                        {
                            var korisnik = db.Korisniks.Where(k => k.ime == imeKorisnika).FirstOrDefault();

                            novcanik novcanik = new novcanik();
                            novcanik.naziv = txtNoviNovcanik.Text.Trim();
                            novcanik.korisnik_id = korisnik.korisnik_id;
                            db.novcaniks.Add(novcanik);
                            db.SaveChanges();

                            cmbNovcanik.Items.Clear();
                            var lista = db.novcaniks.ToList();
                            foreach (var item in lista)
                            {
                                cmbNovcanik.Items.Add(item.naziv);
                            }

                        }
                        catch (Exception p)
                        {
                            MessageBox.Show("Doslo je do greske ", p.InnerException.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Novcanik vec postoji!");
                    }
                }
            }
        }

        private void cmbNovcanik_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MojNovcanik_Context())
            {

                if (cmbNovcanik.SelectedIndex > -1)
                {
                    var novcanik = cmbNovcanik.Text;
                    var idKorisnika = db.Korisniks.Where(k => k.ime == imeKorisnika).FirstOrDefault().korisnik_id;
                    var novcanikObj = db.novcaniks.Where(n => n.korisnik_id == idKorisnika && n.naziv == novcanik).ToList();

                    novcanikId = novcanikObj.FirstOrDefault().novcanik_id;
                    lblBilans.Text = "Bilans: " + novcanikObj.FirstOrDefault().bilans;
                    napuniTransakcije(novcanikId);
                }
            }
        }

        private void btnDodajTransakciju_Click(object sender, EventArgs e)
        {
            Transakcija transakcija = new Transakcija(novcanikId);
            transakcija.Show();
        }

        private void napuniTransakcije(int novcanikId)
        {
            dataGridTransakcije.Rows.Clear();
            dataGridTransakcije.Refresh();
            using (var db = new MojNovcanik_Context())
            {
                var transakcije = db.transakcijas.Where(t => t.novcanik_id == novcanikId).ToList();



                foreach (var t in transakcije)
                {
                    int rowId = dataGridTransakcije.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridTransakcije.Rows[rowId];
                    row.Cells[0].Value = t.transakcija_id;
                    row.Cells[1].Value = t.datum;
                    row.Cells[2].Value = t.iznos;
                    if (t.vrsta_transakcije == false)
                    {
                        row.Cells[3].Value = "Rashod";
                    }
                    if (t.vrsta_transakcije == true)
                    {
                        row.Cells[3].Value = "Prihod";
                    }

                    row.Cells[4].Value = t.ponavljanje;
                    row.Cells[5].Value = t.vreme_ponavljanja;
                }


            }

        }

        private void napuniTransakcije2(int novcanikId)
        {
            // dataGridTransakcije.Dock = DockStyle.Fill;
            // dataGridTransakcije.AutoGenerateColumns = true;



            using (var db = new MojNovcanik_Context())
            {
                var bindingList = new BindingList<transakcija>(db.transakcijas.Where(t => t.novcanik_id == novcanikId).ToList());
                foreach (var item in bindingList)
                {
                    kategorija_transakcije kategorija = new kategorija_transakcije();
                    kategorija.kategorija_id = item.kategorija_id;

                    kategorija.naziv = db.kategorija_transakcije.Where(k => k.kategorija_id == item.kategorija_id).FirstOrDefault().naziv;
                    kategorija.arhivirana = false;
                    item.kategorija_transakcije = kategorija;
                    item.kategorija_transakcije.ToString();
                }
                var source = new BindingSource(bindingList, null);
                dataGridTransakcije.DataSource = source;

            }



            dataGridTransakcije.Columns[0].Visible = false;
            // dataGridTransakcije.Columns["kategorija_transakcije"].Visible = false;
            dataGridTransakcije.Columns["novcanik"].Visible = false;

            // Set the DataGridView control's border.
            dataGridTransakcije.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            dataGridTransakcije.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void napuniTransakcije3(int novcanikId)
        {
            // dataGridTransakcije.Dock = DockStyle.Fill;
            // dataGridTransakcije.AutoGenerateColumns = true;



            using (var db = new MojNovcanik_Context())
            {
                var bindingList = new BindingList<transakcija>(db.transakcijas.Where(t => t.novcanik_id == novcanikId).ToList());
                foreach (var item in bindingList)
                {
                    kategorija_transakcije kategorija = new kategorija_transakcije();
                    kategorija.kategorija_id = item.kategorija_id;

                    kategorija.naziv = db.kategorija_transakcije.Where(k => k.kategorija_id == item.kategorija_id).FirstOrDefault().naziv;
                    kategorija.arhivirana = false;
                    item.kategorija_transakcije = kategorija;
                    item.kategorija_transakcije.ToString();
                }
                var source = new BindingSource(bindingList, null);
                // dataGridTransakcije.DataSource = source;

            }
        }

            private void btnRefreshTransakcije_Click(object sender, EventArgs e)
        {
            using (var db = new MojNovcanik_Context())
            {

                if (cmbNovcanik.SelectedIndex > -1)
                {
                    var novcanik = cmbNovcanik.Text;
                    var idKorisnika = db.Korisniks.Where(k => k.ime == imeKorisnika).FirstOrDefault().korisnik_id;
                    var novcanikObj = db.novcaniks.Where(n => n.korisnik_id == idKorisnika && n.naziv == novcanik).ToList();

                    novcanikId = novcanikObj.FirstOrDefault().novcanik_id;
                    lblBilans.Text = "Bilans: " + novcanikObj.FirstOrDefault().bilans;
                    napuniTransakcije(novcanikId);
                }
            }
        }

        private void Novcanik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moj_novcanikDataSet.kategorija_transakcije' table. You can move, or remove it, as needed.
            this.kategorija_transakcijeTableAdapter.Fill(this.moj_novcanikDataSet.kategorija_transakcije);

        }

        private void btnIzmeniTransakciju_Click(object sender, EventArgs e)
        {
            IzmeniTransakciju izmeniTransakciju = new IzmeniTransakciju(novcanikId);
            izmeniTransakciju.ShowDialog();
        }
    }
}
