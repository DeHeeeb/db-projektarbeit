using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {

        public ProductRepository(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public new List<Product> GetAll()
        {
            using var context = new ProjectContext(Options);
            return context.Products
                .Include(p => p.Group)
                .OrderBy(p => p.ProductNr)
                .ToList();
        }

        public List<Product> Search(string text)
        {
            using var context = new ProjectContext(Options);
            text = text.ToLower();

            return context.Products
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
            using var context = new ProjectContext(Options);
            return context.Products
                .Where(pg => pg.GroupId == productGroup.Id)
                .ToList();
        }
    }
}