using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : DbSet<T>
    {
        private readonly ApplicationDbContext _context;
        public DbSet<T> Table { get; }

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            Table = _context.Set<T>();
        }

        public async Task<bool> Create(T entity)
        {
            try
            {
                await Table.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                Table.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetById(long id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                Table.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}