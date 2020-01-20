namespace MojNovcanik.Domen
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MojNovcanik_Context : DbContext
    {
        public MojNovcanik_Context()
            : base("name=MojNovcanik_Context")
        {
        }

        public virtual DbSet<kategorija_transakcije> kategorija_transakcije { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Mesto> Mestoes { get; set; }
        public virtual DbSet<novcanik> novcaniks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transakcija> transakcijas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kategorija_transakcije>()
                .HasMany(e => e.transakcijas)
                .WithRequired(e => e.kategorija_transakcije)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.novcaniks)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mesto>()
                .HasMany(e => e.Korisniks)
                .WithRequired(e => e.Mesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<novcanik>()
                .HasMany(e => e.transakcijas)
                .WithRequired(e => e.novcanik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transakcija>()
                .Property(e => e.iznos)
                .HasPrecision(18, 0);
        }
    }
}
