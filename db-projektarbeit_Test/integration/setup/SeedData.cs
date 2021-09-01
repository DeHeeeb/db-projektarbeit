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

            customers.ForEach(customer => context.Add(customer));
            cities.ForEach(city => context.Add(city));
        }
    }
}
