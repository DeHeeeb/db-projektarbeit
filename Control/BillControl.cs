using db_projektarbeit.Model;
using System.Collections.Generic;

namespace db_projektarbeit.Control
{
    class BillControl
    {
        private BillModel BillModel = new BillModel();

        public List<Bill> GetAll()
        {
            return BillModel.GetAll();
        }

        public List<Bill> Search(string text)
        {
            return BillModel.Search(text);
        }

        public int Save(Bill bill)
        {
            return BillModel.Save(bill);
        }
    }
}