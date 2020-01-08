using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojNovcanik.Domen
{
    class Novcanik
    {
        int id;
        string naziv;
        double bilans;
        int vlasnikID;

        public Novcanik(int id, string naziv, double bilans, int vlasnikID)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Bilans = bilans;
            this.VlasnikID = vlasnikID;
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Bilans { get => bilans; set => bilans = value; }
        public int VlasnikID { get => vlasnikID; set => vlasnikID = value; }
    }
}
