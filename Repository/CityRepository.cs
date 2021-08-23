using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class CityRepository : RepositoryBase<City>
    {
        public CityRepository(ProjectContext context) : base(context)
        {
        }

        public List<City> Search(string text, ProjectContext context)
        {
            text = text.ToLower();

            return context.Cities
                .Where(c =>
                    c.Zip.ToString().ToLower().Contains(text) ||
                    c.Name.ToLower().Contains(text)
                ).OrderBy(c => c.Zip)
                .ToList();
        }


    }
}