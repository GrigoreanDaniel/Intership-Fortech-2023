﻿namespace AssetManagement.Application.Models.Responses.Software
{
    public class GetSoftwareTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}