using AssetManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities
{
    public class SoftwareTypeEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Type { get; set; } = string.Empty;

        public ICollection<SoftwareLicenseEntity>? Licenses { get; set; }
    }
}