using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace db_projektarbeit.Model
{
    class HomeModel
    {
        public bool GetStatusSQL()
        {
            int statusSQL = 0;
            using (var context = new ProjectContext())
            {
                try
                {
                    statusSQL = context.Database.ExecuteSqlRaw("Select 1");
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se);
                }
            }

            if (statusSQL == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
