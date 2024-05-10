using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dotMVC.Data
{
    public partial class ShopGNam3Context : DbContext
    {
        public ShopGNam3Context()
            : base("name=ShopGNam3Context")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<background> backgrounds { get; set; }
        public virtual DbSet<binhluan1> binhluan1 { get; set; }
        public virtual DbSet<cthanghoa> cthanghoas { get; set; }
        public virtual DbSet<cthoadon> cthoadons { get; set; }
        public virtual DbSet<hanghoa> hanghoas { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<loai> loais { get; set; }
        public virtual DbSet<mausac> mausacs { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<sizegiay> sizegiays { get; set; }
        public virtual DbSet<tinhtrang> tinhtrangs { get; set; }
        public virtual DbSet<voucher> vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<background>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<binhluan1>()
                .Property(e => e.noidung)
                .IsUnicode(false);

            modelBuilder.Entity<cthanghoa>()
                .Property(e => e.hinh)
                .IsUnicode(false);

            modelBuilder.Entity<hanghoa>()
                .HasMany(e => e.binhluan1)
                .WithRequired(e => e.hanghoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hanghoa>()
                .HasMany(e => e.cthanghoas)
                .WithRequired(e => e.hanghoa)
                .HasForeignKey(e => e.idhanghoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hanghoa>()
                .HasMany(e => e.cthoadons)
                .WithRequired(e => e.hanghoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hoadon>()
                .HasMany(e => e.cthoadons)
                .WithRequired(e => e.hoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .HasMany(e => e.binhluan1)
                .WithRequired(e => e.khachhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<khachhang>()
                .HasMany(e => e.hoadons)
                .WithRequired(e => e.khachhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<loai>()
                .HasMany(e => e.hanghoas)
                .WithRequired(e => e.loai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mausac>()
                .HasMany(e => e.cthanghoas)
                .WithRequired(e => e.mausac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.hoten)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.fb)
                .IsUnicode(false);

            modelBuilder.Entity<sizegiay>()
                .HasMany(e => e.cthanghoas)
                .WithRequired(e => e.sizegiay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tinhtrang>()
                .HasMany(e => e.hoadons)
                .WithRequired(e => e.tinhtrang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<voucher>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<voucher>()
                .HasMany(e => e.hoadons)
                .WithRequired(e => e.voucher)
                .WillCascadeOnDelete(false);
        }
    }
}
