using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class ProductRepository : RepositoryBase<Product>
    {

        private readonly ProjectContext _context;
        public ProductRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public new List<Product> GetAll()
        {
            return _context.Products
                .Include(p => p.Group)
                .OrderBy(p => p.ProductNr)
                .ToList();
        }

        public List<Product> Search(string text)
        {
            text = text.ToLower();

            return _context.Products
                .Include(p => p.Group)
                .Where(p =>
                    p.ProductNr.ToString().ToLower().Contains(text) ||
                    p.Description.ToLower().Contains(text) ||
                    p.CreationDate.ToString().ToLower().Contains(text) ||
                    p.Group.Name.ToLower().Contains(text) ||
                    p.Price.ToString().ToLower().Contains(text)
                ).OrderBy(p => p.ProductNr)
                .ToList();
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return _context.Products
                .Where(pg => pg.GroupId == productGroup.Id)
                .ToList();
        }
    }
}