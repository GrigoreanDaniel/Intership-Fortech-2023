namespace AssetManagement.Application.Models.Responses.User
{
    public class GetUserHardwaresModel
    {
        public int? EmployeeId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string SerialNumber { get; set; } = string.Empty;

        public bool IsInternal { get; set; }

        public bool IsDelegated { get; set; }

        public int? CustomerId { get; set; }
    }
}