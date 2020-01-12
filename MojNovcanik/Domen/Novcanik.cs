namespace MojNovcanik.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("novcanik")]
    public partial class novcanik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public novcanik()
        {
            transakcijas = new HashSet<transakcija>();
        }

        [Key]
        public int novcanik_id { get; set; }

        [Required]
        [StringLength(100)]
        public string naziv { get; set; }

        public decimal bilans { get; set; }

        public int korisnik_id { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transakcija> transakcijas { get; set; }
    }
}
