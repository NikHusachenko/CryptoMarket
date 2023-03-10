using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> Table { get; }

        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> GetById(long id);
        Task<ICollection<T>> GetAll();
    }
}