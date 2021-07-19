using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class PositionRepository : RepositoryBase<Position>
    {
        public List<Position> GetAllByOrderId(int orderId)
        {
            using var context = new ProjectContext();

            return context.Positions
                .Include(p => p.Product)
                .OrderBy(p => p.Id)
                .Where(p => p.OrderId == orderId)
                .ToList();
        }

        public List<Position> Search(string text, int orderId)
        {
            text = text.ToLower();
            using var context = new ProjectContext();

            return context.Positions
                .Include(p => p.Product)
                .ThenInclude(p => p.Group)
                .Where(p =>
                    p.OrderId == orderId &&
                    (
                        p.Product.ProductNr.ToString().ToLower().Contains(text) ||
                        p.Product.Description.ToLower().Contains(text) ||
                        p.Product.Group.Name.ToLower().Contains(text)
                    )
                ).OrderBy(p => p.Id)
                .ToList();
        }
    }
}