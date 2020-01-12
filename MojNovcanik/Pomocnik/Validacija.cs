using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojNovcanik.Pomocnik
{
    class Validacija
    {

        public bool validacijaRegistracije(string ime, string sifra, string mesto)
        {
            if (string.IsNullOrWhiteSpace(ime.Trim()))
            {
                MessageBox.Show("Popunite polje Ime");
                return false;
            }
            if (string.IsNullOrWhiteSpace(sifra.Trim()))
            {
                MessageBox.Show("Popunite polje Sifra");
                return false;
            }
            if (string.IsNullOrWhiteSpace(mesto.Trim()))
            {
                MessageBox.Show("Popunite polje Mesto");
                return false;
            }

            return true;
        }

        public bool validacijaPrijavljivanja(string ime, string sifra)
        {
            if (string.IsNullOrWhiteSpace(ime.Trim()))
            {
                MessageBox.Show("Popunite polje Ime");
                return false;
            }
            if (string.IsNullOrWhiteSpace(sifra.Trim()))
            {
                MessageBox.Show("Popunite polje Sifra");
                return false;
            }

            return true;
        }
    }
}
