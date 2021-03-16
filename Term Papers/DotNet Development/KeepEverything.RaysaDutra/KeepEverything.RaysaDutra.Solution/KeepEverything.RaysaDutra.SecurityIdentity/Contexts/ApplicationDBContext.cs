using System;
using Microsoft.AspNet.Identity.EntityFramework;
using KeepEverything.RaysaDutra.SecurityIdentity.Models;

namespace KeepEverything.RaysaDutra.SecurityIdentity.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext():base("DefaultConnection", throwIfV1Schema: false){ }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
