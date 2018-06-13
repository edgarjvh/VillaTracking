namespace VillaTracking.Web.models
{
    public class Client
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }       
        public int Status { get; set; }
    }
}