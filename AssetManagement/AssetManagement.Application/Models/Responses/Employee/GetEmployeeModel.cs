namespace AssetManagement.Application.Models.Responses.Employee
{
    public class GetEmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public IEnumerable<GetSupervisorModel>? Supervisors { get; set; }
    }
}