namespace Projekt_PPR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opiekunowie")]
    public partial class Opiekunowie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_opiekuna { get; set; }

        [StringLength(50)]
        public string imie { get; set; }

        [StringLength(50)]
        public string nazwisko { get; set; }

        public int? pensja { get; set; }
    }
}
