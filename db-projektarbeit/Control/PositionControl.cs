using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class PositionControl
    {
        private readonly PositionRepository _positionRepository;

        public PositionControl(PositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public List<Position> GetAllByOrderId(int orderId)
        {
            return _positionRepository.GetAllByOrderId(orderId);
        }

        public List<Position> Search(string text, int orderId)
        {
            return _positionRepository.Search(text, orderId);
        }

        public int Save(Position position)
        {
            if (position.Id == 0)
            {
                _positionRepository.Save(position);
            }
            else
            {
                _positionRepository.Update(position);
            }

            return position.Id;
        }

        public int Delete(Position position)
        {
            var deleted = _positionRepository.Delete(position.Id);
            return deleted.Id;
        }
    }
}
