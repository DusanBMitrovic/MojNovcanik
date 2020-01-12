using MojNovcanik.Domen;
using MojNovcanik.Pomocnik;
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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

       

        private void btnRegistrujSeR_Click(object sender, EventArgs e)
        {
            Validacija validacija = new Validacija();
            if (validacija.validacijaRegistracije(txtImeR.Text, txtSifraR.Text, txtMestoR.Text))
            {
                using (var db = new MojNovcanik_Context())
                {
                    try
                    {
                        Mesto mesto = new Mesto();
                        mesto.naziv = txtMestoR.Text.Trim();
                        if (db.Mestoes.Where(m => m.naziv == mesto.naziv).Count() < 1)
                        {
                            db.Mestoes.Add(mesto);
                            db.SaveChanges();

                            Korisnik korisnik = new Korisnik();
                            korisnik.mesto_id = mesto.mesto_id;
                            korisnik.ime = txtImeR.Text.Trim();
                            korisnik.password = txtSifraR.Text.Trim();

                            db.Korisniks.Add(korisnik);
                            db.SaveChanges();
                        }
                        else
                        {
                            var provera = db.Mestoes.Where(m => m.naziv == mesto.naziv).FirstOrDefault();
                            Korisnik korisnik = new Korisnik();
                            
                            korisnik.mesto_id = provera.mesto_id;
                            korisnik.ime = txtImeR.Text.Trim();
                            korisnik.password = txtSifraR.Text.Trim();

                            db.Korisniks.Add(korisnik);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Uspesno registrovan korisnik");
                        this.Close();
                    }
                    catch (Exception p)
                    {
                        MessageBox.Show("Doslo je do greske ", p.InnerException.ToString());

                    }
                }
            }
        }
    }
}
