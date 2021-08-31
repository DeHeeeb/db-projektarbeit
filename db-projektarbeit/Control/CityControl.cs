using System.Collections.Generic;
using System.Linq;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class CityControl
    {
        private readonly CityRepository _cityRepository;

        public CityControl(CityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll()
                .OrderBy(c => c.Zip)
                .ToList();
        }

        public List<City> Search(string text)
        {
            return _cityRepository.Search(text);
        }

        public int Save(City city)
        {
            if (city.Id == 0)
            {
                _cityRepository.Save(city);
            }
            else
            {
                _cityRepository.Update(city);
            }

            return city.Id;
        }

        public int Delete(City city)
        {
            var deleted = _cityRepository.Delete(city.Id);

            return deleted?.Id ?? 0;
        }
    }
}