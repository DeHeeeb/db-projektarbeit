﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Model
{
    class ProjectContext : DbContext
    {
        #region Entitys
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Database=Accounting; Trusted_Connection=True");
            optionsBuilder.EnableSensitiveDataLogging();
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("CustomerNr", schema: "shared")
                .StartsAt(1000);                                                // Index startet bei 1000

            modelBuilder.HasSequence<int>("ProductNr", schema: "shared")
                .StartsAt(10000);                                               // Index startet bei1000

            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerNr)
                .HasDefaultValueSql("NEXT VALUE FOR shared.CustomerNr");

            modelBuilder.Entity<Product>()
                .Property(p => p.ProductNr)
                .HasDefaultValueSql("NEXT VALUE FOR shared.ProductNr");

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.City);

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Group);

            modelBuilder.Entity<ProductGroup>()
                .HasOne(p => p.Parent)                                          // Hat immer ein Eltern Element
                .WithMany()                                                     // Bezihungen zischen einem und Mehreren Elementen
                .HasForeignKey(p => p.ParentId)                                 // Fremdschlüssel zu Eltern Element
                .IsRequired(false)                                              //
                .OnDelete(DeleteBehavior.Restrict);                             // Rekursives löschen 

            #region List of City
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
            #endregion

            #region List of Customer
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Marc Traber AG",
                    Street = "Hauptstrasse 12",
                    CityId = 2
                },
                new Customer
                {
                    Id = 2,
                    Name = "Heeb GmbH",
                    Street = "Winkelstrasse 2",
                    CityId = 3
                }
            };
            #endregion

            #region List of ProductGroup
            var productgroups = new List<ProductGroup>
            {
                new ProductGroup
                {
                    Id = 1,
                    Name = "Büromöbel"
                },
                new ProductGroup
                {
                    Id = 2,
                    Name = "Bürostuhl",
                    ParentId = 1
                },
                new ProductGroup
                {
                    Id = 3,
                    Name = "Korpus",
                    ParentId = 1
                },
                new ProductGroup
                {
                    Id = 4,
                    Name = "Schreibtisch",
                    ParentId = 1
                },
                new ProductGroup
                {
                    Id = 5,
                    Name = "Drucker"
                },
                new ProductGroup
                {
                    Id = 6,
                    Name = "Belegdrucker",
                    ParentId = 5
                },
                new ProductGroup
                {
                    Id = 7,
                    Name = "Farbdrucker",
                    ParentId = 5
                },
                new ProductGroup
                {
                    Id = 8,
                    Name = "Fotodrucker",
                    ParentId = 7
                },
                new ProductGroup
                {
                    Id = 9,
                    Name = "Multifunktionsdrucker",
                    ParentId = 7
                },
                new ProductGroup
                {
                    Id = 10,
                    Name = "Toner",
                    ParentId = 5
                },
                new ProductGroup
                {
                    Id = 11,
                    Name = "Ordner"
                }
            };
            #endregion

            #region List of Product
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    GroupId = 2,
                    Description = "Stuhl mit Armlehnen",
                    Price = 140M
                },
                new Product
                {
                    Id = 2,
                    GroupId = 2,
                    Description = "Stuhl Comfort",
                    Price = 170M
                },
                new Product
                {
                    Id = 3,
                    GroupId = 3,
                    Description = "Rolli",
                    Price = 199.90M
                },
                new Product
                {
                    Id = 4,
                    GroupId = 6,
                    Description = "RT-9000",
                    Price = 360.50M
                },
                new Product
                {
                    Id = 5,
                    GroupId = 8,
                    Description = "Polaroid Thermo",
                    Price = 89.90M
                },
                new Product
                {
                    Id = 6,
                    GroupId = 9,
                    Description = "HP M123XX",
                    Price = 349M
                },
                new Product
                {
                    Id = 7,
                    GroupId = 9,
                    Description = "HP M321YY",
                    Price = 321M
                },
                new Product
                {
                    Id = 8,
                    GroupId = 9,
                    Description = "Brother Deluxe",
                    Price = 430M
                },
                new Product
                {
                    Id = 9,
                    GroupId = 10,
                    Description = "HP all-in-one",
                    Price = 999.90M
                },
                new Product
                {
                    Id = 10,
                    GroupId = 11,
                    Description = "Meier (gelb)",
                    Price = 2.90M
                },
                new Product
                {
                    Id = 11,
                    GroupId = 11,
                    Description = "Meier (blau)",
                    Price = 2.30M
                },
                new Product
                {
                    Id = 12,
                    GroupId = 11,
                    Description = "Meier (grau)",
                    Price = 3M
                }
            };
            #endregion

            #region Preload all Data in the Entity
            cities.ForEach(city => modelBuilder.Entity<City>().HasData(city));
            customers.ForEach(customer => modelBuilder.Entity<Customer>().HasData(customer));
            productgroups.ForEach(group => modelBuilder.Entity<ProductGroup>().HasData(group));
            products.ForEach(product => modelBuilder.Entity<Product>().HasData(product));
            #endregion
        }
    }
}

