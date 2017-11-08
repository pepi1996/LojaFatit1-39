namespace LojaFatitForm1_39.Modeli
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tiketa")]
    public partial class Tiketa
    {
        public int TiketaID { get; set; }

        public int LojtariID { get; set; }

        public int GjiroID { get; set; }

        [StringLength(50)]
        public string Lokacioni { get; set; }

        [StringLength(50)]
        public string Statusi { get; set; }

        public int? NrQellumeve { get; set; }

        public int numri1 { get; set; }

        public int numri2 { get; set; }

        public int numri3 { get; set; }

        public int numri4 { get; set; }

        public int numri5 { get; set; }

        public int numri6 { get; set; }

        public int numri7 { get; set; }

        public virtual Gjiro Gjiro { get; set; }

        public virtual Lojtari Lojtari { get; set; }
    }
}
