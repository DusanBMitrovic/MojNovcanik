namespace MojNovcanik.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kategorija_transakcije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kategorija_transakcije()
        {
            transakcijas = new HashSet<transakcija>();
        }

        [Key]
        public int kategorija_id { get; set; }

        [Required]
        [StringLength(100)]
        public string naziv { get; set; }

        public bool arhivirana { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transakcija> transakcijas { get; set; }
    }
}
