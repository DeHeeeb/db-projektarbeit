using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class CityRepository : RepositoryBase<City>
    {
        private readonly ProjectContext _context;
        public CityRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public List<City> Search(string text)
        {
            text = text.ToLower();

            return _context.Cities
                .Where(c =>
                    c.Zip.ToString().ToLower().Contains(text) ||
                    c.Name.ToLower().Contains(text)
                ).OrderBy(c => c.Zip)
                .ToList();
        }


    }
}