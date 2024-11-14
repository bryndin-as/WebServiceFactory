using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryContracts.Repositories
{
    public interface IGenericRepository<T> : IGenericReadOnlyRepository<T> where T : ItemBase
    {
        Task CreateAsync(T item);

        Task CreateAsync(IEnumerable<T> items);

        Task UpdateAsync(T item);

        Task UpdateAsync(IEnumerable<T> items);

        Task DeleteAsync(T item);

        Task DeleteAsync(IEnumerable<T> items);

    }
}
