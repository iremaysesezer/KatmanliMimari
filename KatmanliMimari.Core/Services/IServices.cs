using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Core.Services
{
    public interface IServices<T> where T : class
    {
        Task<T> GetByIdAsync(int Id);
        IEnumerable<T> GelAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<T> AddRangeAsync(IEnumerable<T> entities);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
