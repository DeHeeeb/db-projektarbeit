using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class HomeControl
    {
        private readonly HomeRepository HomeRepository = new HomeRepository();

        public bool GetStatusSQL()
        {
            return HomeRepository.GetStatusSQL();
        }
    }
}
