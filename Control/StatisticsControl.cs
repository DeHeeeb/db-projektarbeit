using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using db_projektarbeit.Model;

namespace db_projektarbeit.Control
{
    class StatisticsControl
    {
        StatisticsModel statisticsModel = new StatisticsModel();
        public DataTable GetAll()
        {
            return statisticsModel.GetAll();
        }
    }
}
