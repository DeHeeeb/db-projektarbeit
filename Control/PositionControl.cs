using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class PositionControl
    {
        private readonly PositionModel PositionModel = new PositionModel();

        public List<Position> GetAllByOrderId(int orderId)
        {
            return PositionModel.GetAllByOrderId(orderId);
        }

        public List<Position> Search(string text, int orderId)
        {
            return PositionModel.Search(text, orderId);
        }

        public int Save(Position position)
        {
            return PositionModel.Save(position);
        }

        public int Delete(Position position)
        {
            return PositionModel.Delete(position);
        }
    }
}
