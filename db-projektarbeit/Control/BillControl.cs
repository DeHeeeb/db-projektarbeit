using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class BillControl
    {
        private readonly BillRepository BillRepository = new BillRepository(new ProjectContext());

        public List<Bill> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return BillRepository.GetAll(context);
        }

        public List<Bill> Search(string text)
        {
            using ProjectContext context = new ProjectContext();
            return BillRepository.Search(text, context);
        }

        public int Save(Bill bill)
        {
            using ProjectContext context = new ProjectContext();
            var saved = BillRepository.Save(bill, context);
            return saved.Id;
        }
    }
}