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
    public partial class IzmeniTransakciju : Form
    {

        int novcanikId = 0;
        int transakcijaId;
        transakcija transakcija = null;
        public IzmeniTransakciju(int novcanikId)
        {
            this.novcanikId = novcanikId;
            InitializeComponent();
            napuniIdCombobox();
            napuniKategorijaCombobox();
            // napuniPodatkeTransakcije();
        }

        private void IzmeniTransakciju_Load(object sender, EventArgs e)
        {

        }

        private void napuniIdCombobox()
        {
            using (var db = new MojNovcanik_Context())
            {

                cmbTransakcijeID.Items.Clear();
                var lista = db.transakcijas.Where(t => t.novcanik_id == novcanikId).ToList();
                foreach (var item in lista)
                {
                    cmbTransakcijeID.Items.Add(item.transakcija_id);
                }
                cmbTransakcijeID.SelectedIndex = 0;
            }
        }

        private void napuniKategorijaCombobox()
        {
            using (var db = new MojNovcanik_Context())
            {

                cmbKategorija.Items.Clear();
                var lista = db.kategorija_transakcije.ToList();
                foreach (var item in lista)
                {
                    cmbKategorija.Items.Add(item.naziv);
                }
                cmbKategorija.SelectedIndex = 0;
                transakcijaId = Int32.Parse(cmbTransakcijeID.Text);
                transakcija = db.transakcijas.Where(t => t.transakcija_id == transakcijaId).FirstOrDefault();
                napuniPodatkeTransakcije();
            }
        }

        private void napuniPodatkeTransakcije()
        {
            txtIznosTransakcije.Text = transakcija.iznos.ToString();

            if (transakcija.vrsta_transakcije == true)
            {
                checkPrihod.Checked = true;
            }
            else
            {
                checkRashod.Checked = true;
            }

            if (transakcija.ponavljanje == true)
            {
                checkBoxPonavljanje.Checked = true;
            }
            else
            {
                checkBoxPonavljanje.Checked = false;
            }

            dateTimePicker1.Value = (DateTime)transakcija.vreme_ponavljanja;

            using (var db = new MojNovcanik_Context())
            {
                string nazivKategorije = db.kategorija_transakcije.Where(k => k.kategorija_id == transakcija.kategorija_id).FirstOrDefault().naziv;
                cmbKategorija.SelectedIndex = cmbKategorija.FindStringExact(nazivKategorije);

            }
        }

        private void cmbTransakcijeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                using (var db = new MojNovcanik_Context())
                {

                    if (cmbKategorija.SelectedIndex > -1)
                    {
                        transakcijaId = Int32.Parse(cmbTransakcijeID.Text);
                        transakcija = db.transakcijas.Where(t => t.transakcija_id == transakcijaId).FirstOrDefault();
                        napuniPodatkeTransakcije();
                    }
                }
            
        }
    }
}
