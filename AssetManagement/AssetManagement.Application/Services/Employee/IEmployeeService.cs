using AssetManagement.Application.Models.Requests.Employee;
using AssetManagement.Application.Models.Responses.Employee;
using AssetManagement.Application.Models.Responses.User;

namespace AssetManagement.Application.Services.Employee
{
    public interface IEmployeeService
    {
        //public Task<IEnumerable<GetEmployeeALLDetailsModel>> GetEmployees(CancellationToken cancellationToken);

        public Task<IEnumerable<GetUserHardwaresModel>> GetHardwares(int id, CancellationToken cancellationToken);

        public Task<IEnumerable<GetSupervisorModel>> GetSupervisors(int id, CancellationToken cancellationToken);

        public Task<IEnumerable<GetBelowEmployeeModel>> GetBelowEmployees(int id, CancellationToken cancellationToken);

        public Task<GetEmployeeModel> GetEmployee(int id, CancellationToken cancellationToken);

        public Task<GetEmployeeModel> AddEmployee(EmployeeModel employee, CancellationToken cancellationToken);

        public Task<GetEmployeeModel> UpdateEmployee(int id, EmployeeModel newEmployee, CancellationToken cancellationToken);

        public Task<GetEmployeeModel> DeleteEmployee(int id, CancellationToken cancellationToken);
    }
}