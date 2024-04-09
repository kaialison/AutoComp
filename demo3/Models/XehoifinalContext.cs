using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace demo3.Models;

public partial class XehoifinalContext : DbContext
{
    public XehoifinalContext()
    {
    }

    public XehoifinalContext(DbContextOptions<XehoifinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Xse> Xses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=KAI\\KAI;Initial Catalog=Xehoifinal;Integrated Security=True; Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Xse>(entity =>
        {
            entity.HasKey(e => e.Maxe).HasName("PK__xse__7A209EEB1D6BB441");

            entity.ToTable("xse");

            entity.Property(e => e.Maxe)
                .ValueGeneratedNever()
                .HasColumnName("maxe");
            entity.Property(e => e.Anhxe).HasColumnName("anhxe");
            entity.Property(e => e.Cieudaicoso).HasColumnName("cieudaicoso");
            entity.Property(e => e.Congsuat).HasColumnName("congsuat");
            entity.Property(e => e.Dungtich)
                .HasMaxLength(1000)
                .HasColumnName("dungtich");
            entity.Property(e => e.Giathamkhao).HasColumnName("giathamkhao");
            entity.Property(e => e.Hopso)
                .HasMaxLength(1000)
                .HasColumnName("hopso");
            entity.Property(e => e.Khoangsanggam).HasColumnName("khoangsanggam");
            entity.Property(e => e.Kickthuoc)
                .HasMaxLength(1000)
                .HasColumnName("kickthuoc");
            entity.Property(e => e.Kieudongco)
                .HasMaxLength(1000)
                .HasColumnName("kieudongco");
            entity.Property(e => e.Loaixe)
                .HasMaxLength(1000)
                .HasColumnName("loaixe");
            entity.Property(e => e.Momen).HasColumnName("momen");
            entity.Property(e => e.Phankhuc)
                .HasMaxLength(1000)
                .HasColumnName("phankhuc");
            entity.Property(e => e.Phienban)
                .HasMaxLength(3000)
                .HasColumnName("phienban");
            entity.Property(e => e.Soghe).HasColumnName("soghe");
            entity.Property(e => e.Sotuikhi).HasColumnName("sotuikhi");
            entity.Property(e => e.Tenhang)
                .HasMaxLength(3000)
                .HasColumnName("tenhang");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
