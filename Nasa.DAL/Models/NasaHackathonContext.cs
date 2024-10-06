using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Nasa.DAL.Models
{
    public partial class NasaHackathonContext : DbContext
    {
        public NasaHackathonContext()
        {
        }

        public NasaHackathonContext(DbContextOptions<NasaHackathonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Biomass> Biomasses { get; set; }
        public virtual DbSet<Landcover> Landcovers { get; set; }
        public virtual DbSet<Moisture> Moistures { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Rainfall> Rainfalls { get; set; }
        public virtual DbSet<SalinityTolerance> SalinityTolerances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NasaHackathon;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Biomass>(entity =>
            {
                entity.ToTable("Biomass");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Landcover>(entity =>
            {
                entity.ToTable("Landcover");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Moisture>(entity =>
            {
                entity.ToTable("Moisture");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.ToTable("Plant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Des1)
                    .HasMaxLength(150)
                    .HasColumnName("des1");

                entity.Property(e => e.Des2)
                    .HasMaxLength(150)
                    .HasColumnName("des2");

                entity.Property(e => e.Des3)
                    .HasMaxLength(150)
                    .HasColumnName("des3");

                entity.Property(e => e.Des4)
                    .HasMaxLength(150)
                    .HasColumnName("des4");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.Heigh).HasColumnName("heigh");

                entity.Property(e => e.Info1).HasColumnName("info1");

                entity.Property(e => e.Info2).HasColumnName("info2");

                entity.Property(e => e.Info3).HasColumnName("info3");

                entity.Property(e => e.Info4).HasColumnName("info4");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.PlantName).HasMaxLength(150);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Biomass)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.BiomassId)
                    .HasConstraintName("FK_Plant_Biomass");

                entity.HasOne(d => d.Landcover)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.LandcoverId)
                    .HasConstraintName("FK_Plant_Landcover1");

                entity.HasOne(d => d.Moisture)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.MoistureId)
                    .HasConstraintName("FK_Plant_Moisture1");

                entity.HasOne(d => d.Rainfall)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.RainfallId)
                    .HasConstraintName("FK_Plant_Rainfall1");

                entity.HasOne(d => d.Salinity)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.SalinityId)
                    .HasConstraintName("FK_Plant_SalinityTolerance");
            });

            modelBuilder.Entity<Rainfall>(entity =>
            {
                entity.ToTable("Rainfall");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");
            });

            modelBuilder.Entity<SalinityTolerance>(entity =>
            {
                entity.ToTable("SalinityTolerance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
