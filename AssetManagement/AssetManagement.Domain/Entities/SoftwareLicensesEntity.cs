using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class SoftwareLicenseEntity : BaseEntity
    {
        public int SoftwareTypeId { get; set; }

        public SoftwareTypeEntity? SoftwareType { get; set; }

        [Required]
        public string SerialKey { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public bool IsUsed { get; set; }
        public UserSoftwareLicenseEntity? UserSoftwareLicense { get; set; }
    }
}