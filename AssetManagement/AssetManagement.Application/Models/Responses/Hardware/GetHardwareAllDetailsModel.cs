namespace AssetManagement.Application.Models.Responses.Hardware
{
    public class GetHardwareAllDetailsModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public GetHardwareDeviceTypeModel? HardwareDeviceType { get; set; }

        public string SerialNumber { get; set; } = string.Empty;

        public bool IsInternal { get; set; }

        public bool IsDelegated { get; set; }

        public int? EmployeeId { get; set; }

        public int? CustomerId { get; set; }
    }
}