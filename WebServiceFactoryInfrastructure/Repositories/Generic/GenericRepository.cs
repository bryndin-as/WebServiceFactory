using Microsoft.EntityFrameworkCore;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryInfrastructure.Repositories.Generic
{
    public class GenericRepository<T>(AppDbContext context) : GenericReadonlyRepository<T>(context), IGenericRepository<T> where T : ItemBase
    {
        public virtual async Task CreateAsync(T item)
        {
            dbSet.Add(item);
            await SaveChangesAsync();
        }

        public virtual async Task CreateAsync(IEnumerable<T> items)
        {
            dbSet.AddRange(items);
            await SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T item)
        {
            dbSet.Remove(item);
            await SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(IEnumerable<T> items)
        {
            dbSet.RemoveRange(items);
            await SaveChangesAsync();

        }

        public virtual async Task UpdateAsync(T item)
        {
            dbSet.Entry(item).State = EntityState.Modified;
            await SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(IEnumerable<T> items)
        {
            dbSet.UpdateRange(items);
            await SaveChangesAsync();
        }

        private async Task SaveChangesAsync()
        {
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException dbex)
            {
                throw new Exception(dbex.InnerException?.Message ?? dbex.Message + ": " + string.Join("\r",
                    dbex.Entries
                        .Select(x => $"{x.Entity.GetType().Name}")));

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
