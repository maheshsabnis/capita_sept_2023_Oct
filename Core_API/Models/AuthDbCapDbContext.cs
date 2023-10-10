using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Models
{
    /// <summary>
    /// The Security Database Connection Mapping and Data Access Layer
    /// </summary>
    public class AuthDbCapDbContext : IdentityDbContext<IdentityUser>
    {
        /// <summary>
        /// The AuthDbCapDbContext class s ready for DI and hence its will also resolve the
        /// IdentityDbContext<IdentityUser> in the Container
        /// </summary>
        /// <param name="options"></param>
        public AuthDbCapDbContext(DbContextOptions<AuthDbCapDbContext> options):base(options)
        {
            
        }
        /// <summary>
        /// THis will create Mapping between Identity classes and the database
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
