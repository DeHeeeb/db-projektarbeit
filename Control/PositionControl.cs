using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class PositionControl
    {
        private readonly PositionRepository PositionRepository = new PositionRepository(new ProjectContext());

        public List<Position> GetAllByOrderId(int orderId)
        {
            return PositionRepository.GetAllByOrderId(orderId);
        }

        public List<Position> Search(string text, int orderId)
        {
            return PositionRepository.Search(text, orderId);
        }

        public int Save(Position position)
        {
            if (position.Id == 0)
            {
                PositionRepository.Save(position);
            }
            else
            {
                PositionRepository.Update(position);
            }

            return position.Id;
        }

        public int Delete(Position position)
        {
            var deleted = PositionRepository.Delete(position.Id);
            return deleted.Id;
        }
    }
}
