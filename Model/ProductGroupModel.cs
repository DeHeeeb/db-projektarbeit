using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace db_projektarbeit.Model
{
    class ProductGroupModel
    {
        public List<ProductGroup> GetAll()
        {
            List<ProductGroup> productGroups = new List<ProductGroup>();

            using (var context = new ProjectContext())
            {
                var result = context.ProductGroups.FromSqlRaw(
                    ";WITH CTE_ProductGroup " +
                    "(Id, Name, ParentId, ProductLevel) " +
                    "AS (SELECT " +
                                "Id," +
                                "Name," +
                                "ParentId," +
                                "0 AS ProductLevel " +
                    "FROM dbo.ProductGroups " +
                    "WHERE ParentId IS NULL " +
                    "UNION ALL " +
                    "SELECT " +
                                "pn.Id," +
                                "pn.Name," +
                                "pn.ParentId," +
                                "p1.ProductLevel + 1 " +
                    "FROM dbo.ProductGroups AS pn " +
                    "INNER JOIN CTE_ProductGroup AS p1 " +
                        "ON p1.Id = pn.ParentId " +
                    ") " +
                    "SELECT " +
                                "Id," +
                                "Name," +
                                "ParentId," +
                                "ProductLevel " +
                    "FROM CTE_ProductGroup " +
                    "ORDER BY ParentId;"
                    );

                foreach (var item in result)
                {
                    productGroups.Add(item);
                }
            }
            return productGroups;
        }

        public int AddNode(ProductGroup productGroup)
        {

            using (var context = new ProjectContext())
            {
                if (productGroup.Id == 0)
                {
                    context.ProductGroups.Add(productGroup);
                }
                else
                {
                    context.ProductGroups.Update(productGroup);
                }

                context.SaveChanges();
            }
            return productGroup.Id;
        }

        public int UpdateNode(ProductGroup productGroup)
        {
            using (var context = new ProjectContext())
            {
                context.ProductGroups.Update(productGroup);
                context.SaveChanges();
            }

            return productGroup.Id;
        }
    }
}
