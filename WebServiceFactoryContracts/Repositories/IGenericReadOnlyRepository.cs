using System.Linq.Expressions;

namespace WebServiceFactoryContracts.Repositories
{
    public interface IGenericReadOnlyRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);

    }
}
