using AssetManagement.Domain.Common;

namespace AssetManagement.Domain.Entities
{
    public class SupervisorEmployeeEntity : DateTimeEntity
    {
        public int EmployeeId { get; set; }
        public EmployeeEntity? Employee { get; set; }
        public int SupervisorId { get; set; }
        public EmployeeEntity? Supervisor { get; set; }
    }
}