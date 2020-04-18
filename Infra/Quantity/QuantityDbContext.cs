using Microsoft.EntityFrameworkCore;
using SportClub.Data.Quantity;

namespace SportClub.Infra.Quantity
{
    public class QuantityDbContext: DbContext
    {
        public DbSet<TrainingData> Trainings { get; set; }
        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder) //loob tabelid
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
            
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<TrainingData>().ToTable(nameof(Trainings));
        }
    }
}
