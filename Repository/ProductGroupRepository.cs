using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Repository
{
    class ProductGroupRepository : RepositoryBase<ProductGroup>
    {
        private readonly ProjectContext _context;
        public ProductGroupRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public new List<ProductGroup> GetAll()
        {
            List<ProductGroup> productGroups = new List<ProductGroup>();


            var result = _context.ProductGroups.FromSqlRaw(
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
            return productGroups;
        }
    }
}
