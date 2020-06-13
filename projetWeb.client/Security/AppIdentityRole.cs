using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace projetWeb.client.Security
{
    // the AppIdentityRole class represents a user role
    public class AppIdentityRole: IdentityRole
    {
        public string Description { get; set; }
    }
}
