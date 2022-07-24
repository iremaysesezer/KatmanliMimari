using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KatmanliMimari.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int Id);
        IQueryable<T> GelAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<T> AddRangeAsync(IEnumerable<T> entities);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);


    }
}
