namespace Projekt_PPR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zwierzaki")]
    public partial class Zwierzaki
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string imie { get; set; }

        [StringLength(50)]
        public string rasa { get; set; }

        public int? wiek { get; set; }

        [StringLength(20)]
        public string kontakt { get; set; }

        [StringLength(50)]
        public string zdj { get; set; }

        public int? opiekun { get; set; }

        public void nowy_zwierzak(int id, string imie, string rasa, int? wiek, string kontakt, string zdj, int? opiekun)
        {
            this.id = id;
            this.imie = imie;
            this.rasa = rasa;
            this.wiek = wiek;
            this.kontakt = kontakt;
            this.zdj = zdj;
            this.opiekun = opiekun;
        }
    }
}
