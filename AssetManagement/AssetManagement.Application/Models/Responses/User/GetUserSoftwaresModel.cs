namespace AssetManagement.Application.Models.Responses.User
{
    public class GetUserSoftwaresModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string SerialKey { get; set; } = string.Empty;
        public bool Actived { get; set; }
    }
}