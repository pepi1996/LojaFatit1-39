namespace LojaFatitForm1_39.Modeli
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LojaContext : DbContext
    {
        public LojaContext()
            : base("name=LojaContext4")
        {
        }

        public virtual DbSet<Gjiro> Gjirot { get; set; }
        public virtual DbSet<Lojtari> Lojtaret { get; set; }
        public virtual DbSet<Tiketa> Tiketat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gjiro>()
                .Property(e => e.Emri)
                .IsUnicode(false);

            modelBuilder.Entity<Gjiro>()
                .HasMany(e => e.Tiketa)
                .WithRequired(e => e.Gjiro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Emri)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Mbiemri)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Lojtari>()
                .HasMany(e => e.Tiketa)
                .WithRequired(e => e.Lojtari)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tiketa>()
                .Property(e => e.Lokacioni)
                .IsUnicode(false);

            modelBuilder.Entity<Tiketa>()
                .Property(e => e.Statusi)
                .IsUnicode(false);
        }
    }
}
