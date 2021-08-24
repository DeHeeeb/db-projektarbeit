using System.Collections.Generic;

namespace db_projektarbeit.Repository
{
    interface IRepositoryBase<M>
    {
        List<M> GetAll(ProjectContext context);

        M Save(M entity, ProjectContext context);

        M Update(M entity, ProjectContext context);

        M Delete(int id, ProjectContext context);
    }
}