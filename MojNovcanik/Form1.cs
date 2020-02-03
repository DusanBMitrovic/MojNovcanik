using MojNovcanik.Domen;
using MojNovcanik.Forme;
using MojNovcanik.Pomocnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private Boolean proveriPassword(string username, string password)
        {
            string savedPasswordHash;
            byte[] hashBytes;
            byte[] salt;

            using (var db = new MojNovcanik_Context())
            {
                savedPasswordHash = db.Korisniks.Where(k => k.ime == username).FirstOrDefault().password;
                hashBytes = Convert.FromBase64String(savedPasswordHash);
                salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                return true;
            }

        }
        
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Validacija validacija = new Validacija();
            if (validacija.validacijaPrijavljivanja(txtImeP.Text, txtSifraP.Text))
            {
                using (var db = new MojNovcanik_Context())
                {
                    

                    if (db.Korisniks.Where(k => k.ime == txtImeP.Text.Trim()).Count() < 1 || !proveriPassword(txtImeP.Text.Trim(),txtSifraP.Text.Trim() ) )
                    {
                        lblObavestenja.Text = "Netacna sifra ili ime korisnika";
                    }
                    else
                    {
                        Novcanik novcanik = new Novcanik(txtImeP.Text.Trim());
                        this.Hide();
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
