using AssetManagement.Application.Models.Requests.Employee;

namespace AssetManagement.Application.Models.Responses.Employee
{
    public class GetSupervisorModel : EmployeeModel
    {
        public int SupervisorId { get; set; }
    }
}