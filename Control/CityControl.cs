using db_projektarbeit.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
