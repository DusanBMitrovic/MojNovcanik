using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojNovcanik.Domen

{
    public enum vrstaTransakcije
    {
        PRIHOD, RASHOD
    }
    class Transakcija
    {
        int id;
        double iznos;
        DateTime datum;
        bool ponavljanje;
        string vremePonavljanja;
        vrstaTransakcije vrstaTransakcije;
        int kategorijaTransakcijeID;

        public Transakcija(int id, double iznos, DateTime datum, bool ponavljanje, string vremePonavljanja, vrstaTransakcije vrstaTransakcije, int kategorijaTransakcijeID)
        {
            this.Id = id;
            this.Iznos = iznos;
            this.Datum = datum;
            this.Ponavljanje = ponavljanje;
            this.VremePonavljanja = vremePonavljanja;
            this.VrstaTransakcije = vrstaTransakcije;
            this.KategorijaTransakcijeID = kategorijaTransakcijeID;
        }

        public int Id { get => id; set => id = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public bool Ponavljanje { get => ponavljanje; set => ponavljanje = value; }
        public string VremePonavljanja { get => vremePonavljanja; set => vremePonavljanja = value; }
        public vrstaTransakcije VrstaTransakcije { get => vrstaTransakcije; set => vrstaTransakcije = value; }
        public int KategorijaTransakcijeID { get => kategorijaTransakcijeID; set => kategorijaTransakcijeID = value; }
    }
}
