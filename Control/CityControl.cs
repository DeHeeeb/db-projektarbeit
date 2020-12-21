using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private CityModel CityModel = new CityModel();

        public List<City> GetCities()
        {
            return CityModel.GetCities();
        }

    }
}
