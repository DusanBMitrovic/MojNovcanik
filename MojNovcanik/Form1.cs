using MojNovcanik.Domen;
using MojNovcanik.Forme;
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

namespace MojNovcanik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Validacija validacija = new Validacija();
            if (validacija.validacijaPrijavljivanja(txtImeP.Text, txtSifraP.Text))
            {
                using (var db = new MojNovcanik_Context())
                {
                    if (db.Korisniks.Where(k => k.ime == txtImeP.Text.Trim()).Count() < 1 || db.Korisniks.Where(k => k.password == txtSifraP.Text.Trim()).Count() < 1)
                    {
                        lblObavestenja.Text = "Korisnik nepostoji ili je netacna sifra";
                    }
                    else
                    {
                        Novcanik novcanik = new Novcanik(txtImeP.Text.Trim());
                        novcanik.Show();
                    }
                }
            }
            else
            {

            }

        }
    }
}
