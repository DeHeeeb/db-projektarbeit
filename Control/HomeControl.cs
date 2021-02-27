using db_projektarbeit.Model;

namespace db_projektarbeit.Control
{
    class HomeControl
    {
        private readonly HomeModel HomeModel = new HomeModel();

        public bool GetStatusSQL()
        {
            return HomeModel.GetStatusSQL();
        }
    }
}
