using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojNovcanik.Domen
{
    class Mesto
    {
        int id;
        String naziv;

        public Mesto(int id, string naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
