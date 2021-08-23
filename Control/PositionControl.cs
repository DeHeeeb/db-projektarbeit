using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class PositionControl
    {
        private readonly PositionRepository PositionRepository = new PositionRepository(new ProjectContext());

        public List<Position> GetAllByOrderId(int orderId)
        {
            using ProjectContext context = new ProjectContext();
            return PositionRepository.GetAllByOrderId(orderId, context);
        }

        public List<Position> Search(string text, int orderId)
        {
            using ProjectContext context = new ProjectContext();
            return PositionRepository.Search(text, orderId, context);
        }

        public int Save(Position position)
        {
            using ProjectContext context = new ProjectContext();
            if (position.Id == 0)
            {
                PositionRepository.Save(position, context);
            }
            else
            {
                PositionRepository.Update(position, context);
            }

            return position.Id;
        }

        public int Delete(Position position)
        {
            using ProjectContext context = new ProjectContext();
            var deleted = PositionRepository.Delete(position.Id, context);
            return deleted.Id;
        }
    }
}
