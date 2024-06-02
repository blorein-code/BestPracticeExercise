using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        // productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        Task<IEnumerable<T>> GetAllAsync();
        // productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        //çoklu ekleme işlemi için
        Task AddRangeAsync(IEnumerable<T> entities);
        void UpdateAsync(T entity);
        void RemoveAsync(T entity);
        void RemoveRangeAsync(IEnumerable<T> entities);

    }
}
