using System.Data;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class StatisticsControl
    {
        private readonly StatisticsRepository StatisticsRepository = new StatisticsRepository();

        public DataTable GetAllSelf()
        {
            return StatisticsRepository.GetAllSelf();
        }

        public DataTable GetAllCustomer()
        {
            return StatisticsRepository.GetAllCustomer();
        }
    }
}