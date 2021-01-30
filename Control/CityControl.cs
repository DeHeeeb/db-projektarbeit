using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private CityModel CityModel = new CityModel();

        public List<City> GetAll()
        {
            return CityModel.GetAll();
        }

        public City GetByZip(int zip)
        {
            return CityModel.GetByZip(zip);
        }

        public List<City> Search(string text)
        {
            return CityModel.Search(text);
        }

        public int Save(City city)
        {
            return CityModel.Save(city);
        }

        public int Delete(City city)
        {
            return CityModel.Delete(city);
        }
    }
}
