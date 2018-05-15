using Newtonsoft.Json;

namespace VillaTracking.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dni")]
        public long Dni { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("phone_number1")]
        public long PhoneNumber1 { get; set; }

        [JsonProperty("phone_number2")]
        public long? PhoneNumber2 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("permission_level")]
        public int PermissionLevel { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        public User()
        {
            Id = 0;
            LastName = string.Empty;
            Status = 1;
            PhoneNumber2 = 0;
        }
    }
}
