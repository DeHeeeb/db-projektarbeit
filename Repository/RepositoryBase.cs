using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit.Repository
{
    abstract class RepositoryBase<M> : IRepositoryBase<M> where M : class
    {
        private readonly ProjectContext _context;

        public RepositoryBase(ProjectContext context)
        {
            _context = context;
        }

        public List<M> GetAll()
        {
            var table = _context.Set<M>();

            return table.ToList();
        }

        public M Save(M entity)
        {
            var table = _context.Set<M>();
            var attach = table.Attach(entity);
            _context.SaveChanges();

            return attach.Entity;
        }

        public M Update(M entity)
        {
            var table = _context.Set<M>();
            var attach = table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return attach.Entity;
        }

        public M Delete(int id)
        {
            var table = _context.Set<M>();
            var existing = table.Find(id);

            try
            {
                table.Remove(existing);
                _context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return existing;
        }
    }
}