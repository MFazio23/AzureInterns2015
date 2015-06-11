using System;

namespace AzureBlueSun_WebServicesASPNet.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string IPAddress { get; set; }
        public string Gender { get; set; }
    }
}