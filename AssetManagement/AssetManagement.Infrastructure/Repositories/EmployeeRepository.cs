using AssetManagement.Application.Repositories;
using AssetManagement.Domain.Entities;
using AssetManagement.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Infrastructure.Repositories;

public class EmployeeRepository : BaseRepository<EmployeeEntity>, IEmployeeRepository
{
    public EmployeeRepository(DatabaseContext context) : base(context)
    {
    }

    public override async Task<List<EmployeeEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        if (_context is null)
        {
            // ToDo: Introduce logging and log the error before return
            // ToDo: Eliminate cases when everythign is included.
            return new List<EmployeeEntity>();
        }

        return await _context.Employees
          .Include(e => e.UserSoftwareLicenses)
          .Include(e => e.UserHardwareDevices)
          .Include(e => e.BelowEmployees)
          .Include(e => e.Supervisors)
          .ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<EmployeeEntity?> GetEmployeeWithSupervisorsAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.Employees
            .Include(e => e.Supervisors)
            .ThenInclude(s => s.Supervisor)
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public async Task<EmployeeEntity?> GetBelowEmpAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.Employees
            .Include(e => e.BelowEmployees)
            .ThenInclude(s => s.Employee)
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public async Task<EmployeeEntity?> GetHardwares(int id, CancellationToken cancellationToken)
    {
        return await _context.Employees
            .Include(e => e.UserHardwareDevices)
            .ThenInclude(u => u.HardwareDevice)
            .Include(e => e.UserHardwareDevices)
            .ThenInclude(s => s.Employee)
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }
}