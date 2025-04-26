// Models/ExternalUsers/ExternalUsersResponse.cs
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MiPrimeraApi.Models.ExternalUsers
{
    public class ExternalUsersResponse
    {
        public int page { get; set; }
        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }
        public int total { get; set; }
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
        public List<ExternalUser>? data { get; set; } // Hecho nullable
        public SupportInfo? support { get; set; } // Hecho nullable
    }

    public class ExternalUser
    {
        public int id { get; set; }
        public string? email { get; set; } // Hecho nullable
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; } // Hecho nullable
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; } // Hecho nullable
        public string? avatar { get; set; } // Hecho nullable
    }

    public class SupportInfo
    {
        public string? url { get; set; } // Hecho nullable
        public string? text { get; set; } // Hecho nullable
    }
}