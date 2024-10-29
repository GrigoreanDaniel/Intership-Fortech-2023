using AssetManagement.Domain.Common;

namespace AssetManagement.Domain.Entities
{
    public class UserSoftwareLicenseEntity : BaseEntity
    {
        public int SoftwareLicenseId { get; set; }
        public SoftwareLicenseEntity? SoftwareLicense { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeEntity? Employee { get; set; }
    }
}