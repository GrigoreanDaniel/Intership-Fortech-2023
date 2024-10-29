using AssetManagement.Domain.Entities;

namespace AssetManagement.Application.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<EmployeeEntity?> GetEmployeeWithSupervisorsAsync(int id, CancellationToken cancellationToken);

        public Task<EmployeeEntity?> GetBelowEmpAsync(int id, CancellationToken cancellationToken);

        public Task<EmployeeEntity?> GetHardwares(int id, CancellationToken cancellationToken);
    }
}