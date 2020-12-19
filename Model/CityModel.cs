using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_projektarbeit.Model
{
    class CityModel
    {
        public List<City> GetCities()
        {
            using (var context = new ProjectContext())
            {
                return context.Cities.ToList();
            }
        }
    }
}
