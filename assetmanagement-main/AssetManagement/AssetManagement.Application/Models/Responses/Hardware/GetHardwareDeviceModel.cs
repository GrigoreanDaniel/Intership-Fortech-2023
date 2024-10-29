namespace AssetManagement.Application.Models.Responses.Hardware
{
    public class GetHardwareDeviceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int HardwareDeviceTypeId { get; set; }

        public GetHardwareDeviceTypeModel? HardwareDeviceType { get; set; }

        public string SerialNumber { get; set; } = string.Empty;

        public bool IsInternal { get; set; }

        public bool IsDelegated { get; set; }
    }
}