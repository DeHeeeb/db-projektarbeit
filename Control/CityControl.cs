using System.Collections.Generic;
using System.Linq;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private readonly CityRepository CityRepository = new CityRepository();

        public List<City> GetAll()
        {
            return CityRepository.GetAll()
                .OrderBy(c => c.Zip)
                .ToList();
        }

        public List<City> Search(string text)
        {
            return CityRepository.Search(text);
        }

        public int Save(City city)
        {
            if (city.Id == 0)
            {
                CityRepository.Save(city);
            }
            else
            {
                CityRepository.Update(city);
            }

            return city.Id;
        }

        public int Delete(City city)
        {
            var deleted = CityRepository.Delete(city.Id);

            return deleted?.Id ?? 0;
        }
    }
}