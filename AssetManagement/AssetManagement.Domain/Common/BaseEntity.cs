using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Common
{
    public class BaseEntity : DateTimeEntity
    {
        [Key]
        public int Id { get; set; }
    }
}