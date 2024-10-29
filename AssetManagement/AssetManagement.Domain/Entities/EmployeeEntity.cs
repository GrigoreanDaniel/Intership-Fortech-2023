using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public ICollection<UserSoftwareLicenseEntity> UserSoftwareLicenses { get; set; } = default!;

        public ICollection<UserHardwareDeviceEntity> UserHardwareDevices { get; set; } = default!;

        public ICollection<SupervisorEmployeeEntity> Supervisors { get; set; } = default!;

        public ICollection<SupervisorEmployeeEntity> BelowEmployees { get; set; } = default!;
    }
}