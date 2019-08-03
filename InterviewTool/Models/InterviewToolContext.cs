namespace InterviewTool.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InterviewToolContext : DbContext
    {
        public InterviewToolContext()
            : base("name=InterviewToolContext")
        {
        }

        public virtual DbSet<Antwort_Text> Antwort_Text { get; set; }
        public virtual DbSet<Ergebni> Ergebnis { get; set; }
        public virtual DbSet<Fachgebiet> Fachgebiets { get; set; }
        public virtual DbSet<Frage> Frages { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<Kompetenz> Kompetenzs { get; set; }
        public virtual DbSet<Skalar> Skalars { get; set; }
        public virtual DbSet<Teilnehmer> Teilnehmers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage1)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage2)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage3)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage4)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage5)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage6)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage7)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage8)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage9)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .Property(e => e.ErgFrage10)
                .IsFixedLength();

            modelBuilder.Entity<Ergebni>()
                .HasMany(e => e.Teilnehmers)
                .WithRequired(e => e.Ergebni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fachgebiet>()
                .HasMany(e => e.Interviews)
                .WithRequired(e => e.Fachgebiet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Frage>()
                .Property(e => e.Bezeichnung)
                .IsFixedLength();

            modelBuilder.Entity<Interview>()
                .Property(e => e.Titel)
                .IsUnicode(false);
        }
    }
}
