using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class ProductRepository : RepositoryBase<Product>
    {

        public ProductRepository(ProjectContext context) : base(context)
        {
        }

        public new List<Product> GetAll(ProjectContext context)
        {
            return context.Products
                .Include(p => p.Group)
                .OrderBy(p => p.ProductNr)
                .ToList();
        }

        public List<Product> Search(string text, ProjectContext context)
        {
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

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup, ProjectContext context)
        {
            return context.Products
                .Where(pg => pg.GroupId == productGroup.Id)
                .ToList();
        }
    }
}