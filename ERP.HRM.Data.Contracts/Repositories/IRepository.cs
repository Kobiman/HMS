using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.HRM.Data.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        ValueTask<T> GetByIdAsync(string id);
        ValueTask<T> GetByIdAsync(CancellationToken cancellationToken, object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void UpdateRange(IList<T> entityList);
        void AddRange(IList<T> entityList);
    }
}
