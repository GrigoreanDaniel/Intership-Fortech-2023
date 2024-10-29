using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class HardwareDeviceEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int HardwareDeviceTypeId { get; set; }

        public HardwareDeviceType? HardwareDeviceType { get; set; }

        public string SerialNumber { get; set; } = string.Empty;

        public bool IsUsed { get; set; }

        public UserHardwareDeviceEntity? UserHardwareDevice { get; set; }
    }
}