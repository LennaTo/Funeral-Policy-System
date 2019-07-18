using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FuneralPolicyApp.Models
{
    public class OurDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserAccount> userAccount { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Policy> Policies { get; set; }




        public DbSet<Claim> Claims { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<DependantStatus> DependantStatuses { get; set; }
        public DbSet<PolicyStatus> PolicyStatuses { get; set; }
        public DbSet<Premium> Premiums { get; set; }

    }
}