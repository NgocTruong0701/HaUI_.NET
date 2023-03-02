using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WPF_DB_QLKETQUA.Models
{
    public partial class QuanLySVContext : DbContext
    {
        public QuanLySVContext()
        {
        }

        public QuanLySVContext(DbContextOptions<QuanLySVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kq> Kqs { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<Sv> Svs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4HMMPQ9\\SQLEXPRESS;Initial Catalog=QuanLySV;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Kq>(entity =>
            {
                entity.HasKey(e => new { e.MaSv, e.MaMh });

                entity.ToTable("KQ");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .HasColumnName("MaSV")
                    .IsFixedLength(true);

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength(true);

                entity.Property(e => e.Diem).HasColumnType("decimal(3, 2)");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.Kqs)
                    .HasForeignKey(d => d.MaMh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KQ_MON");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.Kqs)
                    .HasForeignKey(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KQ_SV");
            });

            modelBuilder.Entity<Mon>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MON__2725DFD9455E3CDC");

                entity.ToTable("MON");

                entity.HasIndex(e => e.TenMh, "unique_TenMH")
                    .IsUnique();

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength(true);

                entity.Property(e => e.Sotc).HasDefaultValueSql("((3))");

                entity.Property(e => e.TenMh)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TenMH");
            });

            modelBuilder.Entity<Sv>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SV__2725081AAA636412");

                entity.ToTable("SV");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .HasColumnName("MaSV")
                    .IsFixedLength(true);

                entity.Property(e => e.Que).HasMaxLength(30);

                entity.Property(e => e.TenSv)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TenSV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
