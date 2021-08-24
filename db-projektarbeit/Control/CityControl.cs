using System.Collections.Generic;
using System.Linq;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class CityControl
    {
        private readonly CityRepository CityRepository = new CityRepository(new ProjectContext());

        public List<City> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return CityRepository.GetAll(context)
                .OrderBy(c => c.Zip)
                .ToList();
        }

        public List<City> Search(string text)
        {
            using ProjectContext context = new ProjectContext();
            return CityRepository.Search(text, context);
        }

        public int Save(City city)
        {
            using ProjectContext context = new ProjectContext();
            if (city.Id == 0)
            {
                CityRepository.Save(city, context);
            }
            else
            {
                CityRepository.Update(city, context);
            }

            return city.Id;
        }

        public int Delete(City city)
        {
            using ProjectContext context = new ProjectContext();
            var deleted = CityRepository.Delete(city.Id, context);

            return deleted?.Id ?? 0;
        }
    }
}