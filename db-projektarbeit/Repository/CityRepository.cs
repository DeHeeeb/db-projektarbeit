using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Repository
{
    public class CityRepository : RepositoryBase<City>
    {
        public CityRepository(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public List<City> Search(string text)
        {
            using var context = new ProjectContext(Options);
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