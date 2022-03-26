﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class ETicaretContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Windows Authentication
            //string connectionString = "server=.;database=BA_ETicaretCore8523;trusted_connection=true;multipleactiveresultsets=true;";
            string connectionString = "server=.;database=BA_ETicaretCore8523;user id=sa;password=123;multipleactiveresultsets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .HasOne(urun => urun.Kategori)
                .WithMany(kategori => kategori.Urunler)
                .HasForeignKey(urun => urun.KategoriId)
                .OnDelete(DeleteBehavior.NoAction);
                //.ToTable("ETicaretUrunler") tablo isimlerini bu şekilde değiştirebiliriz
        }
    }
}
