using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class CityRepository : RepositoryBase<City>
    {
        public List<City> Search(string text)
        {
            text = text.ToLower();
            using var context = new ProjectContext();

            return context.Cities
                .Where(c =>
                    c.Zip.ToString().ToLower().Contains(text) ||
                    c.Name.ToLower().Contains(text)
                ).OrderBy(c => c.Zip)
                .ToList();
        }
    }
}