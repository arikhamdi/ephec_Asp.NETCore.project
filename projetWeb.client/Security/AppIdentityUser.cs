using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace projetWeb.client.Security
{
    // The AppIdentityUser class represents the application’s user
    public class AppIdentityUser : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public bool Professional { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
