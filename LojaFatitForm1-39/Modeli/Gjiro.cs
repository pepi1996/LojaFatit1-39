namespace LojaFatitForm1_39.Modeli
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gjiro")]
    public partial class Gjiro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gjiro()
        {
            Tiketa = new HashSet<Tiketa>();
        }

        public int GjiroID { get; set; }

        [Required]
        [StringLength(50)]
        public string Emri { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? numri1 { get; set; }

        public int? numri2 { get; set; }

        public int? numri3 { get; set; }

        public int? numri4 { get; set; }

        public int? numri5 { get; set; }

        public int? numri6 { get; set; }

        public int? numri7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tiketa> Tiketa { get; set; }
    }
}
