using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace demo3.Models
{
    public partial class Xehoi2Context : DbContext
    {
        public Xehoi2Context()
        {
        }

        public Xehoi2Context(DbContextOptions<Xehoi2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=KAI\\KAI;Initial Catalog=Xehoi2;Integrated Security=True; Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.HasKey(e => e.Maxe)
                    .HasName("PK__xe__7A209EEBDB6FCDCC");

                entity.ToTable("xe");

                entity.Property(e => e.Maxe)
                    .ValueGeneratedNever()
                    .HasColumnName("maxe");

                entity.Property(e => e.Cieudaicoso).HasColumnName("cieudaicoso");

                entity.Property(e => e.Congsuat).HasColumnName("congsuat");

                entity.Property(e => e.Dungtich)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("dungtich");

                entity.Property(e => e.Giathamkhao).HasColumnName("giathamkhao");

                entity.Property(e => e.Hopso)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("hopso");

                entity.Property(e => e.Khoangsanggam).HasColumnName("khoangsanggam");

                entity.Property(e => e.Kickthuoc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("kickthuoc");

                entity.Property(e => e.Kieudongco)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("kieudongco");

                entity.Property(e => e.Loaixe)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("loaixe");

                entity.Property(e => e.Momen).HasColumnName("momen");

                entity.Property(e => e.Phankhuc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("phankhuc");

                entity.Property(e => e.Phienban)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .HasColumnName("phienban");

                entity.Property(e => e.Soghe).HasColumnName("soghe");

                entity.Property(e => e.Sotuikhi).HasColumnName("sotuikhi");

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .HasColumnName("tenhang");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
