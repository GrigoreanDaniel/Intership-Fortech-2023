using AssetManagement.Domain.Common;

namespace AssetManagement.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        void Delete(T entity);

        Task<T?> GetAsync(int id, CancellationToken cancellationToken);

        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);

        Task SaveChangesAsync();
    }
}