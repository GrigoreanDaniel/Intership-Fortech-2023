namespace AssetManagement.Domain.Common
{
    public class DateTimeEntity
    {
        public DateTimeOffset? DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
    }
}