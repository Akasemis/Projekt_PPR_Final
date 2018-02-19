namespace Projekt_PPR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oddane")]
    public partial class Oddane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_operacji { get; set; }

        [StringLength(50)]
        public string rasa { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }
        public void nowa_historia(int ID_operacji, string rasa, DateTime data)
        {
            this.ID_operacji = ID_operacji;
            this.rasa = rasa;
            this.data = data;
        }
    }
}
