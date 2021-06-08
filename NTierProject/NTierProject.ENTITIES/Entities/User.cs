using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Entities
{
    public enum Role
    {
        None = 0,
        Member = 1,
        Admin = 2
    }
    public class User : CoreEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public Role? Role { get; set; }
        public DateTime? BirthDate { get; set; }

        // Navigation Property
        public List<Order> Orders { get; set; }
    }
}
