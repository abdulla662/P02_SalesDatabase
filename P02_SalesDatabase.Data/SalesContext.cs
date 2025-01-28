using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.P02_SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");


            base.OnConfiguring(optionsBuilder);



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
          .Property(b => b.Name)
          .HasMaxLength(50)
          .IsUnicode(true);


            modelBuilder.Entity< Customer> ()
         .Property(b => b.Name)
         .HasMaxLength(100)
         .IsUnicode(true);

            modelBuilder.Entity<Customer>()
           .Property(b => b.Email)
            .HasMaxLength(80)
            .IsUnicode(false);


            modelBuilder.Entity<Store>()
          .Property(b => b.Name)
           .HasMaxLength(80)
           .IsUnicode(true);


            modelBuilder.Entity<Product>().Property(b => b.Description).HasMaxLength(250);

            modelBuilder.Entity<Sale>().Property(b => b.Date).HasDefaultValueSql("GETDATE()");


        }
    }
}
