namespace LojaFatitForm1_39.Modeli
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lojtari")]
    public partial class Lojtari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lojtari()
        {
            Tiketa = new HashSet<Tiketa>();
        }

        public int LojtariID { get; set; }

        [Required]
        [StringLength(50)]
        public string Emri { get; set; }

        [Required]
        [StringLength(50)]
        public string Mbiemri { get; set; }

        public int Mosha { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int Statusi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tiketa> Tiketa { get; set; }
    }
}
