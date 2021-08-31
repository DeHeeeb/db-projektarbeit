using System.Data;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class StatisticsControl
    {
        private readonly StatisticsRepository _statisticsRepository;

        public StatisticsControl(StatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public DataTable GetAllSelf()
        {
            return _statisticsRepository.GetAllSelf();
        }

        public DataTable GetAllCustomer()
        {
            return _statisticsRepository.GetAllCustomer();
        }
    }
}