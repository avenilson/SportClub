//using Microsoft.EntityFrameworkCore;
//using SportClub.Data.Coach;

//namespace SportClub.Infra
//{
//    public class SportClubDbContext : DbContext
//    {
//        public DbSet<CoachData> Coaches { get; set; }
//        public DbSet<CoachOfTraining> CoachesOfTrainings { get; set; }
//        public DbSet<SystemOfUnitsData> SystemsOfUnits { get; set; }
//        public DbSet<UnitFactorData> UnitFactors { get; set; }
//        public DbSet<MeasureTermData> MeasureTerms { get; set; }
//        public DbSet<UnitTermData> UnitTerms { get; set; }
//        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
//            : base(options) { }

//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//            InitializeTables(builder);
//        }

//        public static void InitializeTables(ModelBuilder builder)
//        {
//            if (builder is null) return;
//            builder.Entity<MeasureData>().ToTable(nameof(Measures));
//            builder.Entity<UnitData>().ToTable(nameof(Units));
//            builder.Entity<SystemOfUnitsData>().ToTable(nameof(SystemsOfUnits));
//            builder.Entity<UnitFactorData>().ToTable(nameof(UnitFactors)).HasKey(x => new { x.UnitId, x.SystemOfUnitsId });
//            builder.Entity<MeasureTermData>().ToTable(nameof(MeasureTerms)).HasKey(x => new { x.MasterId, x.TermId });
//            builder.Entity<UnitTermData>().ToTable(nameof(UnitTerms)).HasKey(x => new { x.MasterId, x.TermId });
//        }
//    }
//}
