using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace projetWeb.client.Security
{
    // The AppIdentityDbContext class represents a custom DbContext
    // that is used to communicate with the underlying user and role data store
    // IdentityDbCon text<TUser, TRole, TKey>
    public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser,AppIdentityRole,string>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {

        }
    }
}
