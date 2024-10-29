using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Application.Models.Responses.Software
{
    public class GetSoftwareLicenseModel
    {
        [Key]
        public int Id { get; set; }

        public int SoftwareTypeId { get; set; }

        public GetSoftwareTypeModel? SoftwareType { get; set; }
        public string SerialKey { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}