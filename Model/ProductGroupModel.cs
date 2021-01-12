using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace db_projektarbeit.Model
{
    class ProductGroupModel
    {
        public List<ProductGroup> GetAll()
        {
            var productGroups = new List<ProductGroup>();

            using (var context = new ProjectContext())
            {
                productGroups = context.ProductGroups
                    .Include(p => p.Children)
                    .Include(p => p.Parent)
                    .ToList();
                /*var result = context.ProductGroups.FromSqlRaw(
                    ";WITH CTE_ProductGroup " +
                    "(Id, Name, ParentId, ProductGroupId, ProductLevel) " +
                    "AS (SELECT " +
                                "Id," +
                                "Name," +
                                "ParentId," +
                                "ProductGroupId," +
                                "0 AS ProductLevel " +
                    "FROM dbo.ProductGroups " +
                    "WHERE ParentId IS NULL " +
                    "UNION ALL " +
                    "SELECT " +
                                "pn.Id," +
                                "pn.Name," +
                                "pn.ProductGroupId," +
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
                                "ProductGroupId," +
                                "ProductLevel " +
                    "FROM CTE_ProductGroup " +
                    "ORDER BY ParentId;"
                    );

                foreach (var item in result)
                {
                    productGroups.Add(item);
                }
            }*/
            }

            return productGroups;
        }
    }
}
