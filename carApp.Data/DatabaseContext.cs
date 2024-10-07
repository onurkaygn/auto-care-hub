using carApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=OtoServisSatis;Integrated Security= True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            modelBuilder.Entity<Marka>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50"); //Data Annotation alternative.
            modelBuilder.Entity<Rol>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50"); //Data Annotation alternative.

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                Adi = "Admin"
            });
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 2,
                Adi = "Admin",
                Soyadi = "Admin",
                Telefon = "0555 555 55 55",
                AktifMi = true,
                EklenmeTarihi = DateTime.Now,
                Email = "admin@otoservissatis.tc",
                KullaniciAdi = "admin",
                Sifre = "123456",
                Rol = new Rol { Id = 1 },
                RolId = 1,
            });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }
    }
}
