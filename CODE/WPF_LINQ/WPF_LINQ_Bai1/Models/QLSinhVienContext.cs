using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WPF_LINQ_Bai1.Models
{
    public partial class QLSinhVienContext : DbContext
    {
        public QLSinhVienContext()
        {
        }

        public QLSinhVienContext(DbContextOptions<QLSinhVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4HMMPQ9\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__6539040541F845C8");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(30)
                    .HasColumnName("SoDT");

                entity.Property(e => e.TenKhoa).HasMaxLength(30);
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__Lop__3B98D273CE892689");

                entity.ToTable("Lop");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Phong).HasMaxLength(30);

                entity.Property(e => e.TenLop).HasMaxLength(30);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SinhVien__2725081ABF285369");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .HasColumnName("MaSV")
                    .IsFixedLength(true);

                entity.Property(e => e.GioiTinh).HasMaxLength(30);

                entity.Property(e => e.HoTen).HasMaxLength(30);

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgaySinh).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
