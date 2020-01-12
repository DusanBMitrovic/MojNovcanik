namespace MojNovcanik.Domen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            novcaniks = new HashSet<novcanik>();
        }

        [Key]
        public int korisnik_id { get; set; }

        [Required]
        [StringLength(100)]
        public string ime { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        public int mesto_id { get; set; }

        public virtual Mesto Mesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<novcanik> novcaniks { get; set; }
    }
}
