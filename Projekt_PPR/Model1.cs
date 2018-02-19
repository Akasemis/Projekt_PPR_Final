namespace Projekt_PPR
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Oddane> Oddane { get; set; }
        public virtual DbSet<Opiekunowie> Opiekunowie { get; set; }
        public virtual DbSet<Zwierzaki> Zwierzaki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oddane>()
                .Property(e => e.rasa)
                .IsUnicode(false);

            modelBuilder.Entity<Opiekunowie>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<Opiekunowie>()
                .Property(e => e.nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Zwierzaki>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<Zwierzaki>()
                .Property(e => e.rasa)
                .IsUnicode(false);

            modelBuilder.Entity<Zwierzaki>()
                .Property(e => e.kontakt)
                .IsUnicode(false);

            modelBuilder.Entity<Zwierzaki>()
                .Property(e => e.zdj)
                .IsUnicode(false);
        }
    }
}
