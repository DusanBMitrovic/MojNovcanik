using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojNovcanik.Domen
{
    class Korisnik
    {
        int id;
        string ime;
        string password;
        int mestoID;

        public Korisnik(int id, string ime, string password, int mestoID)
        {
            this.Id = id;
            this.Ime = ime;
            this.Password = password;
            this.MestoID = mestoID;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Password { get => password; set => password = value; }
        public int MestoID { get => mestoID; set => mestoID = value; }
    }
}
