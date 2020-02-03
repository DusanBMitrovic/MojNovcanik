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
    public partial class Transakcija : Form
    {
        string kategorija = "";
        int idKategorije = 0;
        int novcanikId = 0;
        public Transakcija(int novcanikId)
        {
            InitializeComponent();
            using (var db = new MojNovcanik_Context())
            {

                cmbKategorija.Items.Clear();
                var lista = db.kategorija_transakcije.ToList();
                foreach (var item in lista)
                {
                    cmbKategorija.Items.Add(item.naziv);
                    cmbKategorija.SelectedIndex = 0;
                }
            }
            this.novcanikId = novcanikId;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            using (var db = new MojNovcanik_Context())
            {
                if (!string.IsNullOrWhiteSpace(txtDodajKategoriju.Text.Trim()))
                {
                    kategorija_transakcije kategorija = new kategorija_transakcije();
                    kategorija.naziv = txtDodajKategoriju.Text.Trim();
                    kategorija.arhivirana = false;
                    try
                    {
                        db.kategorija_transakcije.Add(kategorija);
                        db.SaveChanges();
                        MessageBox.Show("Uspesno sacuvana transakcija");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Greska");
                    }



                    cmbKategorija.Items.Clear();
                    var lista = db.kategorija_transakcije.ToList();
                    foreach (var item in lista)
                    {
                        cmbKategorija.Items.Add(item.naziv);
                    }
                    MessageBox.Show("Uspesno dodata kategorija transakcije");
                }
                else
                {
                    MessageBox.Show("Obavezno je uneti naziv kategorije");
                }
                
            }
        }

        private void btnZapamtiTransakciju_Click(object sender, EventArgs e)
        {
            int broj = 0;
            transakcija transakcija = new transakcija();
            using (var db = new MojNovcanik_Context())
            {
               
           
                if (!string.IsNullOrWhiteSpace(txtIznosTransakcije.Text.Trim()) || int.TryParse(txtIznosTransakcije.Text, out broj))
                {
                    transakcija.iznos = int.Parse(txtIznosTransakcije.Text);
                    if (datumPonavljanja.Value != null)
                    {
                        transakcija.vreme_ponavljanja = datumPonavljanja.Value;
                    }
                    else
                    {

                    }
                    if (checkPonavljanje.Checked)
                    {
                        transakcija.ponavljanje = true;
                    }
                    else
                    {
                        transakcija.ponavljanje = false;
                    }

                    if (checkPrihod.Checked)
                    {
                        transakcija.vrsta_transakcije = true;
                    }
                    if (checkRashod.Checked)
                    {
                        transakcija.vrsta_transakcije = false;
                    }
                    transakcija.kategorija_id = idKategorije;
                    transakcija.datum = DateTime.Now;
                    transakcija.novcanik_id = novcanikId;

                    try
                    {
                        db.transakcijas.Add(transakcija);
                        novcanik novcanik = db.novcaniks.Where(n => n.novcanik_id == novcanikId).FirstOrDefault();
                        if(transakcija.vrsta_transakcije == true)
                        {
                            novcanik.bilans = novcanik.bilans + transakcija.iznos;
                        }
                        else
                        {
                            novcanik.bilans = novcanik.bilans - transakcija.iznos;
                        }
                        db.SaveChanges();
                        MessageBox.Show("Uspesno ste sacuvali transakciju !");
                    }
                    catch (Exception p)
                    {
                        MessageBox.Show("Doslo je do greske, pokusajte ponovo malo kasnije ");
                    }

                }
                else
                {

                }
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new MojNovcanik_Context())
            {

                if (cmbKategorija.SelectedIndex > -1)
                {
                    kategorija = cmbKategorija.Text;
                    idKategorije = db.kategorija_transakcije.Where(k => k.naziv == kategorija).FirstOrDefault().kategorija_id;
                    
                }
            }
        }
    }
}
