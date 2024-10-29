using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class CustomerEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Company { get; set; } = string.Empty;

        public ICollection<UserHardwareDeviceEntity>? UserHardwareDevices { get; set; }
    }
}