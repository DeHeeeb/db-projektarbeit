using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private readonly CityModel CityModel = new CityModel();

        public List<City> GetAll()
        {
            return CityModel.GetAll();
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
