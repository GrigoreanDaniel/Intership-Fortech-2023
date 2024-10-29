using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class HardwareDeviceType : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<HardwareDeviceEntity>? HardwareDevices { get; set; }
    }
}