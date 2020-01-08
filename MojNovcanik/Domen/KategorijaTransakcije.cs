using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojNovcanik.Domen
{
    class KategorijaTransakcije
    {
        int id;
        string naziv;
        bool arhivirana;

        public KategorijaTransakcije(int id, string naziv, bool arhivirana)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Arhivirana = arhivirana;
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public bool Arhivirana { get => arhivirana; set => arhivirana = value; }
    }
}
