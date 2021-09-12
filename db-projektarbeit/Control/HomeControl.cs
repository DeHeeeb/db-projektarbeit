using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class HomeControl
    {
        private readonly HomeRepository _homeRepository;

        public HomeControl(HomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public bool GetStatusSQL()
        {
            return _homeRepository.GetStatusSQL();
        }
    }
}
