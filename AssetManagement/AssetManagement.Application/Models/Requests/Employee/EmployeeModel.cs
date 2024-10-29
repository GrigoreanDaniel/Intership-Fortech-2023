using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Application.Models.Requests.Employee
{
    public class EmployeeModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}