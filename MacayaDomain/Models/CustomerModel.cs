using System;

namespace MacayaDomain.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }      
        public string? FirstName { get; set; }     
        public string? LastName { get; set; }     
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }      
    }
}
