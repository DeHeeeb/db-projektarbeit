using System.Collections.Generic;

namespace db_projektarbeit.Repository
{
    interface IRepositoryBase<M>
    {
        List<M> GetAll();

        M Save(M entity);

        M Update(M entity);

        M Delete(int id);
    }
}