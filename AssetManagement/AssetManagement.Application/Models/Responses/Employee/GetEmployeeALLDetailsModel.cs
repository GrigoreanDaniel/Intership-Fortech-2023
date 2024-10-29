using AssetManagement.Application.Models.Responses.Hardware;
using AssetManagement.Application.Models.Responses.Software;

namespace AssetManagement.Application.Models.Responses.Employee
{
    public class GetEmployeeALLDetailsModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public IEnumerable<GetSoftwareLicenseModel>? SoftwareLicenses { get; set; }
        public IEnumerable<GetHardwareDeviceModel>? HardwareDevices { get; set; }
        public IEnumerable<GetSupervisorModel>? Supervisors { get; set; }
    }
}