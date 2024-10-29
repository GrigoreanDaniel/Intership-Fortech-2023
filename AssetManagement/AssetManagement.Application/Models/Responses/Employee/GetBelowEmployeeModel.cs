using AssetManagement.Application.Models.Requests.Employee;

namespace AssetManagement.Application.Models.Responses.Employee
{
    public class GetBelowEmployeeModel : EmployeeModel
    {
        public int BelowEmpId { get; set; }
    }
}