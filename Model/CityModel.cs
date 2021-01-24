using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using db_projektarbeit.Control;

namespace db_projektarbeit.Model
{
    class CityModel
    {

        public List<City> GetAll()
        {
            using (var context = new ProjectContext())
            {
                return context.Cities
                    .OrderBy(c => c.Zip)
                    .ToList();
            }
        }

        public City GetByZip(int zip)
        {
            using (var context = new ProjectContext())
            {
                return context.Cities.SingleOrDefault(c => c.Zip == zip);
            }
        }

        public List<City> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
                return context.Cities
                    .Where(c =>
                        c.Zip.ToString().ToLower().Contains(text) ||
                        c.Name.ToLower().Contains(text)
                    ).OrderBy(c => c.Zip)
                    .ToList();
            }
        }

        public int Save(City city)
        {
            using (var context = new ProjectContext())
            {
                if (city.Id == 0)
                {
                    context.Cities.Add(city);
                }
                else
                {
                    context.Cities.Update(city);
                }

                context.SaveChanges();

                return city.Id;
            }
        }
    }
}
