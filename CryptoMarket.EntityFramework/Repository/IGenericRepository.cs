using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CryptoMarket.EntityFramework.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> Table { get; }

        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> GetById(long id);
        Task<T> GetBy(Expression<Func<T, bool>> expression);
        Task<ICollection<T>> GetAll();
    }
}