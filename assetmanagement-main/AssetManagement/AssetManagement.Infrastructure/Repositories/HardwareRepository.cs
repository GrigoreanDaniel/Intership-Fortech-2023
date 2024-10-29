using AssetManagement.Application.Repositories;
using AssetManagement.Domain.Entities;
using AssetManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Infrastructure.Repositories
{
    public class HardwareRepository : BaseRepository<EmployeeEntity>, IHardwareRepository
    {
        public HardwareRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<HardwareDeviceEntity?> GetHardwares(int id, CancellationToken cancellationToken)
        {
            return _context.HardwareDevices
                .Include(h => h.HardwareDeviceType)
                .Include(h => h.UserHardwareDevice)
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }
    }
}