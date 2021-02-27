using db_projektarbeit.Model;
using System.Data;

namespace db_projektarbeit.Control
{
    class StatisticsControl
    {
        private readonly StatisticsModel StatisticsModel = new StatisticsModel();

        public DataTable GetAllSelf()
        {
            return StatisticsModel.GetAllSelf();
        }

        public DataTable GetAllCustomer()
        {
            return StatisticsModel.GetAllCustomer();
        }
    }
}
