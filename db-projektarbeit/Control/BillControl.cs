using System.Collections.Generic;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    public class BillControl
    {
        private readonly BillRepository _billRepository;

        public BillControl(BillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public List<Bill> GetAll()
        {
            return _billRepository.GetAll();
        }

        public List<Bill> Search(string text)
        {
            return _billRepository.Search(text);
        }

        public int Save(Bill bill)
        {
            var saved = _billRepository.Save(bill);
            return saved.Id;
        }
    }
}