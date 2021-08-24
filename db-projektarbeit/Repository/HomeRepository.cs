using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace db_projektarbeit.Repository
{
    class HomeRepository
    {
        private readonly ProjectContext _context;
        public HomeRepository(ProjectContext context)
        {
            _context = context;
        }

        public bool GetStatusSQL()
        {
            int statusSQL = 0;
            try
            {
                statusSQL = _context.Database.ExecuteSqlRaw("Select 1");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se);
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
