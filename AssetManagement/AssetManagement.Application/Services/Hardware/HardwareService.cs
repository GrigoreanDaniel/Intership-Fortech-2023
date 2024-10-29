using AssetManagement.Application.Models.Requests.Employee;
using AssetManagement.Application.Models.Responses.Employee;
using AssetManagement.Application.Models.Responses.Hardware;
using AssetManagement.Application.Models.Responses.User;
using AssetManagement.Application.Repositories;
using AssetManagement.Domain.Entities;
using System.Diagnostics.Contracts;

namespace AssetManagement.Application.Services.Hardware
{
    public class HardwareService : IHardwareService
    {
        private readonly IBaseRepository<HardwareDeviceEntity> _baseHardwareRepository;
        private readonly IHardwareRepository _customHardwareRepository;

        public HardwareService(IBaseRepository<HardwareDeviceEntity> hardwareRepository)
        {
            _customHardwareRepository = (IHardwareRepository)hardwareRepository;
            _baseHardwareRepository = hardwareRepository;
        }

        /*public async Task<GetEmployeeModel> AddEmployee(EmployeeModel employee, CancellationToken cancellationToken)
        {
            EmployeeEntity employeeFromDb = await _baseEmployeeRepository.CreateAsync(new EmployeeEntity()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
            });

            await _baseEmployeeRepository.SaveChangesAsync();

            GetEmployeeModel newEmployee = new()
            {
                Id = employeeFromDb.Id,
                FirstName = employeeFromDb.FirstName,
                LastName = employeeFromDb.LastName,
                Email = employeeFromDb.Email
            };

            return newEmployee;
        }

        public async Task<GetEmployeeModel> DeleteEmployee(int id, CancellationToken cancellationToken)
        {
            EmployeeEntity? employee = await _baseEmployeeRepository.GetAsync(id, cancellationToken);

            // ToDo: Verify null and signal error if needed
            if (employee == null)
            {
                return null!;
            }
            else
            {
                _baseEmployeeRepository.Delete(employee);
            }

            await _baseEmployeeRepository.SaveChangesAsync();

            return new GetEmployeeModel();
        }

        public async Task<GetEmployeeModel> GetEmployee(int id, CancellationToken cancellationToken)
        {
            EmployeeEntity? employee = await _baseEmployeeRepository.GetAsync(id, cancellationToken);

            return new GetEmployeeModel()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
            };
        }*/

        public async Task<IEnumerable<GetUserHardwaresModel>> GetHardwares(int id, CancellationToken cancellationToken)
        {
            HardwareDeviceEntity? hardware = await _customHardwareRepository.GetHardwares(id, cancellationToken);

            return null;
            /*return new GetHardwareAllDetailsModel()
            {
                Id = hardware.Id,
                Name = hardware.Name,
                SerialNumber = hardware.SerialNumber,
                HardwareDeviceTypeId = hardware.HardwareDeviceTypeId,
                IsDelegated = hardware.UserHardwareDevice.IsDelegated,
                IsInternal = hardware.UserHardwareDevice.IsInternal,
            };*/
        }

        /*public async Task<GetEmployeeModel> UpdateEmployee(int id, EmployeeModel newEmployee, CancellationToken cancellationToken)
        {
            EmployeeEntity employee = new()
            {
                Id = id,
                FirstName = newEmployee.FirstName,
                LastName = newEmployee.LastName,
                Email = newEmployee.Email
            };

            _ = await _baseEmployeeRepository.UpdateAsync(employee);
            await _baseEmployeeRepository.SaveChangesAsync();

            GetEmployeeModel updatedEmployee = new()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email
            };

            return updatedEmployee;
        }*/
    }
}