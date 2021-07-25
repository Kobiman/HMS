using ERP.HRM.Data.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.HRM.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> DbSet { get; set; }
        protected DbContext Context { get; set; }

        public GenericRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is " +
                    "required to use this repository.", nameof(context));
            }

            Context = context;
            DbSet = Context.Set<T>();
        }
        public void Add(T entity)
        {
           DbSet.Add(entity);
        }

        public void AddRange(IList<T> entityList)
        {
            DbSet.AddRange(entityList);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        public Task<List<T>> GetAllAsync()
        {
            return DbSet.ToListAsync();
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetByIdAsync(string id)
        {
            return DbSet.FindAsync(id);
        }

        public ValueTask<T> GetByIdAsync(CancellationToken cancellationToken, object id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public void UpdateRange(IList<T> entityList)
        {
            DbSet.UpdateRange(entityList);
        }
    }
}
