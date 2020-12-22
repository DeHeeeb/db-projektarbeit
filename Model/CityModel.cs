using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_projektarbeit.Model
{
    class CityModel
    {
        public City GetByZip(int zip)
        {
            using (var context = new ProjectContext())
            {
                return context.Cities.SingleOrDefault(c => c.Zip == zip);
            }
        }

        public int Save(City city)
        {
            using (var context = new ProjectContext())
            {
                context.Cities.Add(city);
                context.SaveChanges();

                return city.Id;
            }
        }
    }
}
