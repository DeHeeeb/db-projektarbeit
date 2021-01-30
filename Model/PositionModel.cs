using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace db_projektarbeit.Model
{
    class PositionModel
    {
        public List<Position> GetAllByOrderId(int orderId)
        {
            using (var context = new ProjectContext())
            {
                return context.Positions
                    .Include(p => p.Product)
                    .OrderBy(p => p.Id)
                    .Where(p => p.OrderId == orderId)
                    .ToList();
            }
        }

        public List<Position> Search(string text, int orderId)
        {
            text = text.ToLower();
            using (var context = new ProjectContext())
            {
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

        public int Save(Position position)
        {
            using (var context = new ProjectContext())
            {
                if (position.Id == 0)
                {
                    context.Positions.Add(position);
                }
                else
                {
                    context.Positions.Update(position);
                }

                context.SaveChanges();

                return position.Id;
            }
        }

        public int Delete(Position position)
        {
            try
            {
                using (var context = new ProjectContext())
                {
                    context.Positions.Remove(position);
                    context.SaveChanges();
                }
            }
            catch
            {
                return 0;
            }

            return position.Id;
        }
    }
}
