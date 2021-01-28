using System;
using System.Collections.Generic;
using System.Text;
using db_projektarbeit.Model;

namespace db_projektarbeit.Control
{
    class HomeControl
    {
        private HomeModel homeModel = new HomeModel();

        public bool GetStatusSQL()
        {
            return homeModel.GetStatusSQL();
        }
    }
}
