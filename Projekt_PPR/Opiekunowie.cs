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
        public Opiekunowie()
        {
            ID_opiekuna = 3;
            imie = "Test";
            nazwisko = "Testowy";
            pensja = 1000;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_opiekuna { get; set; }

        [StringLength(50)]
        public string imie { get; set; }

        [StringLength(50)]
        public string nazwisko { get; set; }

        public int? pensja { get; set; }


        public void nowy_opiekun(int ID_opiekuna, string imie, string nazwisko, int pensja)
        {
            this.ID_opiekuna = ID_opiekuna;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pensja = pensja;
        }

        public void modyfikuj_pensje (int kwota)
        {
            this.pensja = this.pensja + kwota;
        }
    }
}
