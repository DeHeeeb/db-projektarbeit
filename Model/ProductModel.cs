using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_projektarbeit.Model
{
    class ProductModel
    {
        public List<Product> GetAll()
        {
            using (var context = new ProjectContext())
            {
                return context.Products.Include(p => p.Group).ToList();
            }
        }

        /*public List<Product> Search(string text)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
                return context.Customers
                    .Include(c => c.City)
                    .Where(c => 
                        c.CustomerNr.ToString().ToLower().Contains(text) ||
                        c.Name.ToLower().Contains(text) ||
                        c.Street.ToLower().Contains(text) ||
                        c.City.Zip.ToString().ToLower().Contains(text) ||
                        c.City.Name.ToLower().Contains(text)
                    ).ToList();
            }
        }*/

        public int Save(Product product)
        {
            using (var context = new ProjectContext())
            {
                if (product.Id == 0)
                {
                    context.Products.Add(product);
                } else
                {
                    context.Products.Attach(product);
                    context.Entry(product).State = EntityState.Modified;
                }
                context.SaveChanges();

                return product.Id;
            }
        }
    }
}
