using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Model
{
    class ProjectContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=Accounting; Trusted_Connection=True");
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("CustomerNr", schema: "shared")
                .StartsAt(1000);
            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerNr)
                .HasDefaultValueSql("NEXT VALUE FOR shared.CustomerNr");
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.City);

            var cities = new List<City>
            {
                new City
                {
                    Id = 1,
                    Zip = 9000,
                    Name = "St. Gallen"
                },
                new City
                {
                    Id = 2,
                    Zip = 9244,
                    Name = "Niederuzwil"
                },
                new City
                {
                    Id = 3,
                    Zip = 9553,
                    Name = "Bettwiesen"
                }
            };
            cities.ForEach(city => modelBuilder.Entity<City>().HasData(city));
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Marc Traber AG",
                    Street = "Hauptstrasse 12"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Heeb GmbH",
                    Street = "Winkelstrasse 2"
                }
            };

            customers.ForEach(customer => modelBuilder.Entity<Customer>().HasData(customer));
        }
    }
}
