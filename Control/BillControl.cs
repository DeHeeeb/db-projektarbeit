using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class BillControl
    {
        private readonly BillRepository BillRepository = new BillRepository(new ProjectContext());

        public List<Bill> GetAll()
        {
            return BillRepository.GetAll();
        }

        public List<Bill> Search(string text)
        {
            return BillRepository.Search(text);
        }

        public int Save(Bill bill)
        {
            var saved = BillRepository.Save(bill);
            return saved.Id;
        }
    }
}