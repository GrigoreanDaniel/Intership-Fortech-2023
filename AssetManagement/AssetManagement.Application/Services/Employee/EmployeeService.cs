using AssetManagement.Application.Models.Requests.Employee;
using AssetManagement.Application.Models.Responses.Employee;
using AssetManagement.Application.Models.Responses.User;
using AssetManagement.Application.Repositories;
using AssetManagement.Domain.Entities;
using System.Diagnostics.Contracts;

namespace AssetManagement.Application.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IBaseRepository<EmployeeEntity> _baseEmployeeRepository;
        private readonly IEmployeeRepository _customEmployeeRepository;

        public EmployeeService(IBaseRepository<EmployeeEntity> employeeRepository)
        {
            _customEmployeeRepository = (IEmployeeRepository)employeeRepository;
            _baseEmployeeRepository = employeeRepository;
        }

        [Pure]
        public static string GetFullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                return firstName;
            }

            return string.IsNullOrWhiteSpace(firstName) ? lastName : $"{firstName} {lastName}";
        }

        public async Task<GetEmployeeModel> AddEmployee(EmployeeModel employee, CancellationToken cancellationToken)
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

        public async Task<IEnumerable<GetBelowEmployeeModel>> GetBelowEmployees(int id, CancellationToken cancellationToken)
        {
            EmployeeEntity? employee = await _customEmployeeRepository.GetBelowEmpAsync(id, cancellationToken);

            return employee.BelowEmployees.Select(belowEmp =>
            {
                return new GetBelowEmployeeModel()
                {
                    BelowEmpId = belowEmp.Employee.Id,
                    FirstName = belowEmp.Employee.FirstName,
                    LastName = belowEmp.Employee.LastName,
                    Email = belowEmp.Employee.Email
                };
            });
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
        }

        public async Task<IEnumerable<GetUserHardwaresModel>> GetHardwares(int id, CancellationToken cancellationToken)
        {
            EmployeeEntity? employee = await _customEmployeeRepository.GetHardwares(id, cancellationToken);

            return employee.UserHardwareDevices.Select(userHardware =>
            {
                return new GetUserHardwaresModel()
                {
                    EmployeeId = userHardware.Id,
                    Name = userHardware.HardwareDevice.Name,
                    IsInternal = userHardware.IsInternal,
                    IsDelegated = userHardware.IsDelegated,
                    CustomerId = userHardware.CustomerId
                };
            });
        }

        public async Task<IEnumerable<GetSupervisorModel>> GetSupervisors(int id, CancellationToken cancellationToken)
        {
            EmployeeEntity? employee = await _customEmployeeRepository.GetEmployeeWithSupervisorsAsync(id, cancellationToken);

            return employee.Supervisors.Select(supervisor =>
            {
                return new GetSupervisorModel()
                {
                    SupervisorId = supervisor.Employee.Id,
                    FirstName = supervisor.Employee.FirstName,
                    LastName = supervisor.Employee.LastName,
                    Email = supervisor.Employee.Email
                };
            });
        }

        public async Task<GetEmployeeModel> UpdateEmployee(int id, EmployeeModel newEmployee, CancellationToken cancellationToken)
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
        }
    }
}