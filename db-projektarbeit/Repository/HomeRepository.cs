using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Options;

namespace db_projektarbeit.Repository
{
    public class HomeRepository
    {
        private readonly DbContextOptions<ProjectContext> Options;

        public HomeRepository(DbContextOptions<ProjectContext> options)
        {
            Options = options;
        }

        public bool GetStatusSQL()
        {
            using var context = new ProjectContext(Options);
            int statusSQL = 0;
            try
            {
                statusSQL = context.Database.ExecuteSqlRaw("Select 1");
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
