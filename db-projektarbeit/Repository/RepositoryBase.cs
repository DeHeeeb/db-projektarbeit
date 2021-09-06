using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Repository
{
    public abstract class RepositoryBase<M> : IRepositoryBase<M> where M : class
    {
        protected readonly DbContextOptions<ProjectContext> Options;

        public RepositoryBase(DbContextOptions<ProjectContext> options)
        {
            Options = options;
        }

        public List<M> GetAll()
        {
            using var context = new ProjectContext(Options);
            var table = context.Set<M>();

            return table.ToList();
        }

        public M Save(M entity)
        {
            using var context = new ProjectContext(Options);
            var table = context.Set<M>();
            var attach = table.Attach(entity);
            context.SaveChanges();

            return attach.Entity;
        }

        public M Update(M entity)
        {
            using var context = new ProjectContext(Options);
            var table = context.Set<M>();
            var attach = table.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return attach.Entity;
        }

        public M Delete(int id)
        {
            using var context = new ProjectContext(Options);
            var table = context.Set<M>();
            var existing = table.Find(id);

            try
            {
                table.Remove(existing);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return existing;
        }
    }
}