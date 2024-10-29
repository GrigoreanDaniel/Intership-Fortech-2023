using AssetManagement.Domain.Entities;

namespace AssetManagement.Application.Repositories
{
    public interface IHardwareRepository
    {
        public Task<HardwareDeviceEntity?> GetHardwares(int id, CancellationToken cancellationToken);
    }
}