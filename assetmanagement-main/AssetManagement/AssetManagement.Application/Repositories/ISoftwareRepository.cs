using AssetManagement.Domain.Entities;

namespace AssetManagement.Application.Repositories
{
    public interface ISoftwareRepository
    {
        public Task<EmployeeEntity> GetSoftwares(int id, CancellationToken cancellationToken);
    }
}