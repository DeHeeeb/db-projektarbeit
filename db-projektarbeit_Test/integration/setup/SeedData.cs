using System;
using System.Collections.Generic;
using db_projektarbeit;
using db_projektarbeit.Repository;

namespace db_projektarbeit_Test.integration.setup
{
    public class SeedData
    {
        public static void Populate(ProjectContext context)
        {
            var customers = new List<Customer>
            {
                new Customer()
                {
                    Id = 1,
                    FirstName = "Lukas",
                    LastName = "Heeb",
                    ValidFrom = new DateTime(1, 1, 1),
                    ValidTo = new DateTime(3000, 1, 1),
                    CityId = 1
                },
                new Customer()
                {
                    Id = 2,
                    FirstName = "Eric",
                    LastName = "Lüchinger",
                    ValidFrom = new DateTime(1, 1, 1),
                    ValidTo = new DateTime(3000, 1, 1),
                    CityId = 2
                },
                new Customer()
                {
                    Id = 3,
                    FirstName = "Marc",
                    LastName = "Traber",
                    ValidFrom = new DateTime(1, 1, 1),
                    ValidTo = new DateTime(3000, 1, 1),
                    CityId = 3
                }
            };
            var cities = new List<City>
            {
                new City()
                {
                    Id = 1,
                    Zip = 9000,
                    Name = "St. Gallen"
                },
                new City()
                {
                    Id = 2,
                    Zip = 5000,
                    Name = "Aarau"
                },
                new City()
                {
                    Id = 3,
                    Zip = 1000,
                    Name = "Lausanne"
                }
            };
            var productGroups = new List<ProductGroup>()
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
                }
            };
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    GroupId = 2,
                    Description = "Stuhl mit Armlehnen",
                    Price = 140M,
                    CreationDate = new DateTime(2020, 03, 15)
                },
                new Product
                {
                    Id = 2,
                    GroupId = 2,
                    Description = "Stuhl Comfort",
                    Price = 170M,
                    CreationDate = new DateTime(2020, 02, 05)
                },
                new Product
                {
                    Id = 3,
                    GroupId = 3,
                    Description = "Rolli",
                    Price = 199.90M,
                    CreationDate = new DateTime(2020, 01, 25)
                },
                new Product
                {
                    Id = 4,
                    GroupId = 6,
                    Description = "RT-9000",
                    Price = 360.50M,
                    CreationDate = new DateTime(2020, 07, 02)
                }
            };

            customers.ForEach(customer => context.Add(customer));
            cities.ForEach(city => context.Add(city));
            productGroups.ForEach(productGroup => context.Add(productGroup));
            products.ForEach(product => context.Add(product));
        }
    }
}
