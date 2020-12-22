using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private CityModel CityModel = new CityModel();

        public City GetByZip(int zip)
        {
            return CityModel.GetByZip(zip);
        }

        public int Save(City city)
        {
            if (city.Id != 0)
            {
                var fromDb = GetByZip(city.Zip);
                if (fromDb != null)
                {
                    return city.Id;
                } else
                {
                    return CityModel.Save(new City { Name = city.Name, Zip = city.Zip });
                }
            }
            return CityModel.Save(city);
        }

    }
}
