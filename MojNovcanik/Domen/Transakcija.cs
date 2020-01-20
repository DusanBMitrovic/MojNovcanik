namespace MojNovcanik.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("transakcija")]
    public partial class transakcija
    {
        [Key]
        public int transakcija_id { get; set; }

        public decimal iznos { get; set; }

        public DateTime datum { get; set; }

        public bool ponavljanje { get; set; }

        public DateTime? vreme_ponavljanja { get; set; }

        public bool vrsta_transakcije { get; set; }

        public int kategorija_id { get; set; }

        public int novcanik_id { get; set; }

        public virtual kategorija_transakcije kategorija_transakcije { get; set; }

        public virtual novcanik novcanik { get; set; }
    }
}
