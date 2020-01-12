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
            if (cmbNovcanik.SelectedIndex > -1)
            {
                var novcanik = cmbNovcanik.Text;
                MessageBox.Show(novcanik.ToString());
            }
        }
    }
}
