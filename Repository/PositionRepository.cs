using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace db_projektarbeit.Repository
{
    class PositionRepository : RepositoryBase<Position>
    {
        private readonly ProjectContext _context;
        public PositionRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public List<Position> GetAllByOrderId(int orderId)
        {
            return _context.Positions
                .Include(p => p.Product)
                .OrderBy(p => p.Id)
                .Where(p => p.OrderId == orderId)
                .ToList();
        }

        public List<Position> Search(string text, int orderId)
        {
            text = text.ToLower();

            return _context.Positions
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