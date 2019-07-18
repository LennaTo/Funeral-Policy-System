using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FuneralPolicyApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public int Age { get; set; }

        public string Company { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string RoleName): base(RoleName) { }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public DbSet<UserAccount> userAccount { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Policy> Policies { get; set; }




        public DbSet<Claim> Claims { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<DependantStatus> DependantStatuses { get; set; }
        public DbSet<PolicyStatus> PolicyStatuses { get; set; }
        public DbSet<Premium> Premiums { get; set; }

        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<ClaimFile> ClaimFiles { get; set; }

        public DbSet<Commission> Commissions { get; set; }

        public DbSet<PolicyComment> PolicyComments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}