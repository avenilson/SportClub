using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportClub.Infra;

namespace SportClub.Soft.Data
{
    public class SportClubDbContext : IdentityDbContext
    {
        public SportClubDbContext(DbContextOptions<SportClubDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) //loob tabelid
        {
            base.OnModelCreating(builder);
            Infra.SportClubDbContext.InitializeTables(builder);
        }
    }
}
