using System;
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
                .StartsAt(10000);                                               // Index startet bei 1000

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
                .HasOne(p => p.Parent)                  // Hat immer ein Eltern Element
                .WithMany(p => p.Children);             // Bezihungen zischen einem und Mehreren Elementen
                /*.HasForeignKey(p => p.ParentId)       // Fremdschlüssel zu Eltern Element
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);*/   // Rekursives löschen

            //modelBuilder.Entity<Order>()
            //     .HasOne<Customer>()
            //     .WithMany()
            //     .HasForeignKey(c => c.CustomerId);

            //modelBuilder.Entity<Order>()
            //     .HasMany<Position>()
            //     .WithOne()
            //     .HasForeignKey(c => c.OrderId);

            //modelBuilder.Entity<Position>()
            //    .HasOne(p => p.Product);

            //modelBuilder.Entity<Position>()
            //    .HasOne(o => o.Order);

            #region List of City
            var cities = new List<City>
            {
                new City
                {
                    Id = 1,
                    Zip = 9244,
                    Name = "Niederuzwil"
                },
                new City
                {
                    Id = 2,
                    Zip = 9553,
                    Name = "Bettwiesen"
                },
                new City
                {
                    Id = 3,
                    Zip = 9445,
                    Name = "Rebstein"
                },
                new City
                {
                    Id = 4,
                    Zip = 9000,
                    Name = "St. Gallen"
                },
                new City
                {
                    Id = 5,
                    Zip = 9403,
                    Name = "Goldach"
                },
                new City
                {
                    Id = 6,
                    Zip = 9400,
                    Name = "Rorschach"
                },
                new City
                {
                    Id = 7,
                    Zip = 9434,
                    Name = "Au"
                },
                new City
                {
                    Id = 8,
                    Zip = 9444,
                    Name = "Diepoldsau"
                },
                new City
                {
                    Id = 9,
                    Zip = 9475,
                    Name = "Sevelen"
                },
                new City
                {
                    Id = 10,
                    Zip = 9402,
                    Name = "Mörschwil"
                },
                new City
                {
                    Id = 11,
                    Zip = 9320,
                    Name = "Arbon"
                },
                new City
                {
                    Id = 12,
                    Zip = 9327,
                    Name = "Tübach"
                },
                new City
                {
                    Id = 13,
                    Zip = 9305,
                    Name = "Berg (SG)"
                },
                new City
                {
                    Id = 14,
                    Zip = 9053,
                    Name = "Teufen"
                },
                new City
                {
                    Id = 15,
                    Zip = 9056,
                    Name = "Gais"
                },
                new City
                {
                    Id = 16,
                    Zip = 9038,
                    Name = "Rehetobel"
                },
                new City
                {
                    Id = 17,
                    Zip = 9043,
                    Name = "Trogen"
                },
                new City
                {
                    Id = 18,
                    Zip = 9035,
                    Name = "Grub"
                },
                new City
                {
                    Id = 19,
                    Zip = 9064,
                    Name = "Hundwil"
                },
                new City
                {
                    Id = 20,
                    Zip = 9033,
                    Name = "Untereggen"
                },
                new City
                {
                    Id = 21,
                    Zip = 9200,
                    Name = "Gossau"
                },
                new City
                {
                    Id = 22,
                    Zip = 9230,
                    Name = "Flawil"
                },
                new City
                {
                    Id = 23,
                    Zip = 9220,
                    Name = "Bischofszell"
                },
                new City
                {
                    Id = 24,
                    Zip = 9245,
                    Name = "Oberbüren"
                },
                new City
                {
                    Id = 25,
                    Zip = 9243,
                    Name = "Jonschwil"
                },
                new City
                {
                    Id = 26,
                    Zip = 9204,
                    Name = "Andwil (SG)"
                },
                new City
                {
                    Id = 27,
                    Zip = 9216,
                    Name = "Hohentannen"
                },
                new City
                {
                    Id = 28,
                    Zip = 9424,
                    Name = "Rheineck"
                },
                new City
                {
                    Id = 29,
                    Zip = 9470,
                    Name = "Buchs"
                },
                new City
                {
                    Id = 30,
                    Zip = 9425,
                    Name = "Thal"
                }
            };
            #endregion

            #region List of Customer
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Marc",
                    LastName = "Traber",
                    CompanyName = "Traber Corp",
                    Street = "Hauptstrasse",
                    HouseNumber = "12",
                    CityId = 1
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Lukas",
                    LastName = "Heeb",
                    CompanyName = "Heeb GmbH",
                    Street = "Winkelstrasse",
                    HouseNumber = "2",
                    CityId = 2
                },
                new Customer
                {
                    Id = 3,
                    FirstName = "Eric",
                    LastName = "Lüchinger",
                    CompanyName = "CableTec AG",
                    Street = "Bergstrasse",
                    HouseNumber = "25",
                    CityId = 3
                },
                new Customer
                {
                    Id = 4,
                    FirstName = "Charlotte",
                    LastName = "Segmüller",
                    CompanyName = null,
                    Street = "Weiherweg",
                    HouseNumber = "9",
                    CityId = 4
                },
                new Customer
                {
                    Id = 5,
                    FirstName = "Fred",
                    LastName = "Chatwick",
                    CompanyName = "Swisscom AG",
                    Street = "Burggasse",
                    HouseNumber = "2",
                    CityId = 5
                },
                new Customer
                {
                    Id = 6,
                    FirstName = "Selina",
                    LastName = "Schmidt",
                    CompanyName = null,
                    Street = "Im Bohl",
                    HouseNumber = null,
                    CityId = 6
                },
                new Customer
                {
                    Id = 7,
                    FirstName = "Paul",
                    LastName = "Del Curto",
                    CompanyName = "Setca GmbH",
                    Street = "Bahnhofstrasse",
                    HouseNumber = "21",
                    CityId = 7
                },
                new Customer
                {
                    Id = 8,
                    FirstName = "Michelle",
                    LastName = "Terzic",
                    CompanyName = "Bau Köster AG",
                    Street = "Settlerstrasse",
                    HouseNumber = "5",
                    CityId = 8
                },
                new Customer
                {
                    Id = 9,
                    FirstName = "Thorsten",
                    LastName = "Müller",
                    CompanyName = null,
                    Street = "Waldweg",
                    HouseNumber = "2",
                    CityId = 9
                },
                new Customer
                {
                    Id = 10,
                    FirstName = "Andreas",
                    LastName = "Hugentobler",
                    CompanyName = "Contacta GmbH",
                    Street = "Hauptstrasse",
                    HouseNumber = "1",
                    CityId = 10
                },
                new Customer
                {
                    Id = 11,
                    FirstName = "Esther",
                    LastName = "Amgarten",
                    CompanyName = "Stadtverwaltung Arbon",
                    Street = "Rathausplatz",
                    HouseNumber = null,
                    CityId = 11
                },
                new Customer
                {
                    Id = 12,
                    FirstName = "Marianne",
                    LastName = "Stettler",
                    CompanyName = null,
                    Street = "Bachstrasse",
                    HouseNumber = "7",
                    CityId = 11
                },
                new Customer
                {
                    Id = 13,
                    FirstName = "Ernst",
                    LastName = "Hediger",
                    CompanyName = "Eon Pharma AG",
                    Street = "Dinkelweg",
                    HouseNumber = "2",
                    CityId = 12
                },
                new Customer
                {
                    Id = 14,
                    FirstName = "Antonio",
                    LastName = "Perugia",
                    CompanyName = "Raiffeisenbank Berg",
                    Street = "Schlossgasse",
                    HouseNumber = "13",
                    CityId = 13
                },
                new Customer
                {
                    Id = 15,
                    FirstName = "Tina",
                    LastName = "Mächler",
                    CompanyName = "Stampino AG",
                    Street = "Hinterwaldstrasse",
                    HouseNumber = "16",
                    CityId = 14
                },
                new Customer
                {
                    Id = 16,
                    FirstName = "Didier",
                    LastName = "Cuche",
                    CompanyName = "Sport Säntis",
                    Street = "Unter den Linden",
                    HouseNumber = "3",
                    CityId = 15
                },
                new Customer
                {
                    Id = 17,
                    FirstName = "Stefano",
                    LastName = "Dalbacco",
                    CompanyName = null,
                    Street = "Birkenau",
                    HouseNumber = null,
                    CityId = 16
                },
                new Customer
                {
                    Id = 18,
                    FirstName = "Michael",
                    LastName = "Graf",
                    CompanyName = "Sägerei Fenk",
                    Street = "Fuchsweg",
                    HouseNumber = "10",
                    CityId = 17
                },
                new Customer
                {
                    Id = 19,
                    FirstName = "Angela",
                    LastName = "Wick",
                    CompanyName = null,
                    Street = "Dammstrasse",
                    HouseNumber = "75",
                    CityId = 18
                },
                new Customer
                {
                    Id = 20,
                    FirstName = "Patrick",
                    LastName = "Viera",
                    CompanyName = "Sounddog GmbH",
                    Street = "Sonnengasse",
                    HouseNumber = "5",
                    CityId = 19
                },
                new Customer
                {
                    Id = 21,
                    FirstName = "Davide",
                    LastName = "Kluser",
                    CompanyName = "BCJ AG",
                    Street = "Mühlackerweg",
                    HouseNumber = "7",
                    CityId = 9
                },
                new Customer
                {
                    Id = 22,
                    FirstName = "Erich",
                    LastName = "Kästner",
                    CompanyName = "Enderli Buch AG",
                    Street = "Feldwiesenstrasse",
                    HouseNumber = "18",
                    CityId = 20
                },
                new Customer
                {
                    Id = 23,
                    FirstName = "Remo",
                    LastName = "Santiago",
                    CompanyName = "Blumeria GmbH",
                    Street = "Bahnhofstrasse",
                    HouseNumber = "88",
                    CityId = 1
                },
                new Customer
                {
                    Id = 24,
                    FirstName = "Beat",
                    LastName = "Breu",
                    CompanyName = "Velomech.ch AG",
                    Street = "Gartenstrasse",
                    HouseNumber = "1",
                    CityId = 21
                },
                new Customer
                {
                    Id = 25,
                    FirstName = "Jan",
                    LastName = "Steiger",
                    CompanyName = null,
                    Street = "Rorschacherstrasse",
                    HouseNumber = "62",
                    CityId = 8
                },
                new Customer
                {
                    Id = 26,
                    FirstName = "Nadine",
                    LastName = "Niedermann",
                    CompanyName = "Anton Kehrer AG",
                    Street = "Am Bühl",
                    HouseNumber = null,
                    CityId = 22
                },
                new Customer
                {
                    Id = 27,
                    FirstName = "Fabian",
                    LastName = "Buhmann",
                    CompanyName = "Tres Amigos Ristorante",
                    Street = "Hauptstrasse",
                    HouseNumber = "2",
                    CityId = 23
                },
                new Customer
                {
                    Id = 28,
                    FirstName = "Tatjana",
                    LastName = "Kekarova",
                    CompanyName = "Birreria",
                    Street = "Meistergasse",
                    HouseNumber = "92",
                    CityId = 24
                },
                new Customer
                {
                    Id = 29,
                    FirstName = "Selina",
                    LastName = "Gabenthuler",
                    CompanyName = "Pizzeria Antonio",
                    Street = "Postplatz",
                    HouseNumber = "3",
                    CityId = 25
                },
                new Customer
                {
                    Id = 30,
                    FirstName = "Alessia",
                    LastName = "Eichholzer",
                    CompanyName = null,
                    Street = "Im Tobel",
                    HouseNumber = null,
                    CityId = 26
                },
                new Customer
                {
                    Id = 31,
                    FirstName = "Tobias",
                    LastName = "Savello",
                    CompanyName = "TeleVisio Corporation",
                    Street = "Marktgasse",
                    HouseNumber = "32",
                    CityId = 27
                },
                new Customer
                {
                    Id = 32,
                    FirstName = "Daniel",
                    LastName = "Brunner",
                    CompanyName = "CompuTrade GmbH",
                    Street = "Bachstrasse",
                    HouseNumber = "10",
                    CityId = 11
                },
                new Customer
                {
                    Id = 33,
                    FirstName = "Ignazio",
                    LastName = "Torres",
                    CompanyName = "Car Import GmbH",
                    Street = "Rheinstrasse",
                    HouseNumber = "2",
                    CityId = 28
                },
                new Customer
                {
                    Id = 34,
                    FirstName = "Rolf",
                    LastName = "Fringer",
                    CompanyName = "NetworkTrade GmbH",
                    Street = "Pizolerstrasse",
                    HouseNumber = "56",
                    CityId = 29
                },
                new Customer
                {
                    Id = 35,
                    FirstName = "Hubert",
                    LastName = "Gasser",
                    CompanyName = "Gasser Bau AG",
                    Street = "Studenbach",
                    HouseNumber = "11",
                    CityId = 30
                },
                new Customer
                {
                    Id = 36,
                    FirstName = "Bernhard",
                    LastName = "Lutz",
                    CompanyName = null,
                    Street = "Fähnernweg",
                    HouseNumber = "22",
                    CityId = 1
                },
                new Customer
                {
                    Id = 37,
                    FirstName = "Dorothea",
                    LastName = "Mittermeier",
                    CompanyName = "Orthopädie Lüchinger",
                    Street = "Hauptstrasse",
                    HouseNumber = "19",
                    CityId = 3
                },
                new Customer
                {
                    Id = 38,
                    FirstName = "Fritz",
                    LastName = "Baumann",
                    CompanyName = "Sonnenbräu AG",
                    Street = "Hinterstrasse",
                    HouseNumber = "5",
                    CityId = 3
                },
                new Customer
                {
                    Id = 39,
                    FirstName = "Alexander",
                    LastName = "Marty",
                    CompanyName = null,
                    Street = "Kugelgasse",
                    HouseNumber = "15",
                    CityId = 7
                },
                new Customer
                {
                    Id = 40,
                    FirstName = "Manuel",
                    LastName = "Stähli",
                    CompanyName = null,
                    Street = "Lindenweg",
                    HouseNumber = "28",
                    CityId = 11
                },
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
                    Price = 140M,
                    CreationDate = new DateTime(2020,03,15)
                },
                new Product
                {
                    Id = 2,
                    GroupId = 2,
                    Description = "Stuhl Comfort",
                    Price = 170M,
                    CreationDate = new DateTime(2020,02,05)
                },
                new Product
                {
                    Id = 3,
                    GroupId = 3,
                    Description = "Rolli",
                    Price = 199.90M,
                    CreationDate = new DateTime(2020,01,25)
                },
                new Product
                {
                    Id = 4,
                    GroupId = 6,
                    Description = "RT-9000",
                    Price = 360.50M,
                    CreationDate = new DateTime(2020,07,02)
                },
                new Product
                {
                    Id = 5,
                    GroupId = 8,
                    Description = "Polaroid Thermo",
                    Price = 89.90M,
                    CreationDate = new DateTime(2020,10,9)
                },
                new Product
                {
                    Id = 6,
                    GroupId = 9,
                    Description = "HP M123XX",
                    Price = 349M,
                    CreationDate = new DateTime(2020,12,6)
                },
                new Product
                {
                    Id = 7,
                    GroupId = 9,
                    Description = "HP M321YY",
                    Price = 321M,
                    CreationDate = new DateTime(2020,9,17)
                },
                new Product
                {
                    Id = 8,
                    GroupId = 9,
                    Description = "Brother Deluxe",
                    Price = 430M,
                    CreationDate = new DateTime(2020,08,01)
                },
                new Product
                {
                    Id = 9,
                    GroupId = 10,
                    Description = "HP all-in-one",
                    Price = 999.90M,
                    CreationDate = new DateTime(2020,04,7)
                },
                new Product
                {
                    Id = 10,
                    GroupId = 11,
                    Description = "Meier (gelb)",
                    Price = 2.90M,
                    CreationDate = new DateTime(2020,9,9)
                },
                new Product
                {
                    Id = 11,
                    GroupId = 11,
                    Description = "Meier (blau)",
                    Price = 2.30M,
                    CreationDate = new DateTime(2020,6,10)
                },
                new Product
                {
                    Id = 12,
                    GroupId = 11,
                    Description = "Meier (grau)",
                    Price = 3M,
                    CreationDate = new DateTime(2020,10,01)
                }
            };
            #endregion

            #region List of Orders
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    Comment = "3456_Haus_Kohl",
                    Date = new DateTime(2020,12,30)
                },
                new Order
                {
                    Id = 2,
                    CustomerId = 1,
                    Comment = "123_Haus_Tranz",
                    Date = new DateTime(2020,10,11)
                },
                new Order
                {
                    Id = 3,
                    CustomerId = 2,
                    Comment = "000_Haus_google",
                    Date = new DateTime(2020,11,02)
                },
                new Order
                {
                    Id = 4,
                    CustomerId = 3,
                    Comment = "403_Haus_Torsten",
                    Date = new DateTime(2020,09,17)
                },
                new Order
                {
                    Id = 5,
                    CustomerId = 4,
                    Comment = "Privat",
                    Date = new DateTime(2020,08,26)
                },
                new Order
                {
                    Id = 6,
                    CustomerId = 1,
                    Comment = "750_Gotinger_Martin",
                    Date = new DateTime(2020,07,15)
                },
                new Order
                {
                    Id = 7,
                    CustomerId = 2,
                    Comment = "730_Martins",
                    Date = new DateTime(2020,07,01)
                },
                new Order
                {
                    Id = 8,
                    CustomerId = 3,
                    Comment = "730_Martins",
                    Date = new DateTime(2020,06,27)
                },
                new Order
                {
                    Id = 9,
                    CustomerId = 4,
                    Comment = "Brühwiler_Ferienhaus",
                    Date = new DateTime(2020,06,15)
                },
                new Order
                {
                    Id = 10,
                    CustomerId = 1,
                    Comment = "Dubli",
                    Date = new DateTime(2020,06,2)
                },
                new Order
                {
                    Id = 11,
                    CustomerId = 2,
                    Comment = "Butz_Herkingen",
                    Date = new DateTime(2020,05,26)
                },
                new Order
                {
                    Id = 12,
                    CustomerId = 3,
                    Comment = "Brügger_Baden",
                    Date = new DateTime(2020,05,15)
                },
                new Order
                {
                    Id = 13,
                    CustomerId = 4,
                    Comment = "Familenfest",
                    Date = new DateTime(2020,05,2)
                },
                new Order
                {
                    Id = 14,
                    CustomerId = 1,
                    Comment = "642_Gieger_Peter",
                    Date = new DateTime(2020,04,22)
                },
                new Order
                {
                    Id = 15,
                    CustomerId = 2,
                    Comment = "719_Kratt_Manuel",
                    Date = new DateTime(2020,04,03)
                },
                new Order
                {
                    Id = 16,
                    CustomerId = 3,
                    Comment = "149_Böhni_Urs",
                    Date = new DateTime(2020,03,27)
                },
                new Order
                {
                    Id = 17,
                    CustomerId = 4,
                    Comment = "Skiferien",
                    Date = new DateTime(2020,03,08)
                },
                new Order
                {
                    Id = 18,
                    CustomerId = 1,
                    Comment = "639_Spielman_Gorden",
                    Date = new DateTime(2020,02,25)
                },
                new Order
                {
                    Id = 19,
                    CustomerId = 2,
                    Comment = "396_Björn_Kortu",
                    Date = new DateTime(2020,02,05)
                },
                new Order
                {
                    Id = 20,
                    CustomerId = 3,
                    Comment = "999_Karten_Schnutz",
                    Date = new DateTime(2020,01,26)
                },
                new Order
                {
                    Id = 21,
                    CustomerId = 4,
                    Comment = "Garten_Haus",
                    Date = new DateTime(2020,01,15)
                }
                ,
                new Order
                {
                    Id = 22,
                    CustomerId = 1,
                    Comment = "123_holdergarten_Gerd",
                    Date = new DateTime(2020,01,05)
                }

            };

            #endregion

            #region List of Positions
            var positions = new List<Position>
            {
                new Position
                {
                    Id = 1,
                    Count = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Total = 1M
                },
                new Position
                {
                    Id = 2,
                    Count = 3,
                    OrderId = 1,
                    ProductId = 4,
                    Total = 15M
                },
                new Position
                {
                    Id = 3,
                    Count = 2,
                    OrderId = 1,
                    ProductId = 5,
                    Total = 2.50M
                },
                new Position
                {
                    Id = 4,
                    Count = 1,
                    OrderId = 2,
                    ProductId = 8,
                    Total = 17.69M
                },
                new Position
                {
                    Id = 5,
                    Count = 1,
                    OrderId = 3,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 6,
                    Count = 3,
                    OrderId = 3,
                    ProductId = 7,
                    Total = 0M
                },
                new Position
                {
                    Id = 7,
                    Count = 2,
                    OrderId = 4,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 8,
                    Count = 2,
                    OrderId = 5,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 9,
                    Count = 2,
                    OrderId = 5,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 10,
                    Count = 3,
                    OrderId = 6,
                    ProductId = 10,
                    Total = 0M
                },
                new Position
                {
                    Id = 11,
                    Count = 1,
                    OrderId = 6,
                    ProductId = 11,
                    Total = 0M
                },
                new Position
                {
                    Id = 12,
                    Count = 3,
                    OrderId = 6,
                    ProductId = 12,
                    Total = 0M
                },
                new Position
                {
                    Id = 13,
                    Count = 8,
                    OrderId = 7,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 14,
                    Count = 1,
                    OrderId = 7,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 15,
                    Count = 2,
                    OrderId = 8,
                    ProductId = 12,
                    Total = 0M
                },
                new Position
                {
                    Id = 16,
                    Count = 1,
                    OrderId = 8,
                    ProductId = 1,
                    Total = 0M
                },
                new Position
                {
                    Id = 17,
                    Count = 3,
                    OrderId = 9,
                    ProductId = 2,
                    Total = 0M
                },
                new Position
                {
                    Id = 18,
                    Count = 2,
                    OrderId = 10,
                    ProductId = 5,
                    Total = 0M
                },
                new Position
                {
                    Id = 19,
                    Count = 1,
                    OrderId = 10,
                    ProductId = 12,
                    Total = 0M
                },
                new Position
                {
                    Id = 20,
                    Count = 4,
                    OrderId = 11,
                    ProductId = 7,
                    Total = 0M
                },
                new Position
                {
                    Id = 21,
                    Count = 1,
                    OrderId = 12,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 22,
                    Count = 3,
                    OrderId = 13,
                    ProductId = 9,
                    Total = 0M
                },
                new Position
                {
                    Id = 23,
                    Count = 2,
                    OrderId = 13,
                    ProductId = 2,
                    Total = 0M
                },
                new Position
                {
                    Id = 24,
                    Count = 1,
                    OrderId = 14,
                    ProductId = 5,
                    Total = 0M
                },
                new Position
                {
                    Id = 25,
                    Count = 2,
                    OrderId = 15,
                    ProductId = 11,
                    Total = 0M
                },
                new Position
                {
                    Id = 26,
                    Count = 1,
                    OrderId = 15,
                    ProductId = 12,
                    Total = 0M
                },
                new Position
                {
                    Id = 27,
                    Count = 1,
                    OrderId = 16,
                    ProductId = 2,
                    Total = 0M
                },
                new Position
                {
                    Id = 28,
                    Count = 1,
                    OrderId = 16,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 29,
                    Count = 1,
                    OrderId = 17,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 30,
                    Count = 1,
                    OrderId = 18,
                    ProductId = 9,
                    Total = 0M
                },
                new Position
                {
                    Id = 31,
                    Count = 2,
                    OrderId = 18,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 32,
                    Count = 2,
                    OrderId = 19,
                    ProductId = 10,
                    Total = 0M
                },
                new Position
                {
                    Id = 33,
                    Count = 2,
                    OrderId = 19,
                    ProductId = 11,
                    Total = 0M
                },
                new Position
                {
                    Id = 34,
                    Count = 1,
                    OrderId = 19,
                    ProductId = 12,
                    Total = 0M
                },
                new Position
                {
                    Id = 35,
                    Count = 1,
                    OrderId = 20,
                    ProductId = 3,
                    Total = 0M
                },
                new Position
                {
                    Id = 36,
                    Count = 3,
                    OrderId = 21,
                    ProductId = 5,
                    Total = 0M
                },
                new Position
                {
                    Id = 37,
                    Count = 1,
                    OrderId = 21,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 38,
                    Count = 1,
                    OrderId = 22,
                    ProductId = 8,
                    Total = 0M
                },
                new Position
                {
                    Id = 39,
                    Count = 2,
                    OrderId = 22,
                    ProductId = 3,
                    Total = 0M
                }
            };
            #endregion

            #region Preload all Data in the Entity
            cities.ForEach(city => modelBuilder.Entity<City>().HasData(city));
            customers.ForEach(customer => modelBuilder.Entity<Customer>().HasData(customer));
            productgroups.ForEach(group => modelBuilder.Entity<ProductGroup>().HasData(group));
            products.ForEach(product => modelBuilder.Entity<Product>().HasData(product));
            orders.ForEach(order => modelBuilder.Entity<Order>().HasData(order));
            positions.ForEach(positions => modelBuilder.Entity<Position>().HasData(positions));
            #endregion
        }
    }
}

