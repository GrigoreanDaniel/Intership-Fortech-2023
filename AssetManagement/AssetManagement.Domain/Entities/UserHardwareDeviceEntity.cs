using AssetManagement.Domain.Common;

namespace AssetManagement.Domain.Entities
{
    public class UserHardwareDeviceEntity : BaseEntity
    {
        public CustomerEntity? Customer { get; set; }

        public int? CustomerId { get; set; }

        public EmployeeEntity? Employee { get; set; }

        public int? EmployeeId { get; set; }

        public HardwareDeviceEntity? HardwareDevice { get; set; }

        public int HardwareDeviceId { get; set; }

        /// <summary>
        /// Indicates whether the hardware is used at the moment for a delegation.
        /// </summary>
        public bool IsDelegated { get; set; }

        public bool IsInternal { get; set; }
    }
}