using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;

namespace WebServiceFactoryInfrastructure.Repositories.Generic
{
    public class GenericReadonlyRepository<T>(AppDbContext context) : IGenericReadOnlyRepository<T> where T : class
    {
        protected readonly AppDbContext db = context;
        protected DbSet<T> dbSet = context.Set<T>();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }
    }
}
