namespace VillaTracking.WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public long Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Address { get; set; }
        public long PhoneNumber1 { get; set; }
        public long? PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public int PermissionLevel { get; set; }
        public string Pass { get; set; }
        public object Image { get; set; }
        public int Status { get; set; }

        public User()
        {
            Id = 0;
            LastName = string.Empty;
            Status = 1;
            PhoneNumber2 = 0;
            Pass = string.Empty;
            Image = string.Empty;
        }
    }
}