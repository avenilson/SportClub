using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportClub.Infra;
namespace SportClub.Soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        internal void InitializeTables(ModelBuilder builder) => SportClubDbContext.InitializeTables(builder);
    }
}
