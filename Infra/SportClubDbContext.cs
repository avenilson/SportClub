using Microsoft.EntityFrameworkCore;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;

namespace SportClub.Infra
{
    public class SportClubDbContext : DbContext
    {
        public DbSet<CoachData> Coaches { get; set; }
        public DbSet<CoachOfTrainingData> CoachesOfTrainings { get; set; }
        public DbSet<ParticipantData> Participants { get; set; }
        public DbSet<ParticipantOfTrainingData> ParticipantsOfTrainings { get; set; }
        public DbSet<TrainingData> Trainings { get; set; }
        public DbSet<TrainingTypeData> TrainingTypes { get; set; }
        public SportClubDbContext(DbContextOptions<SportClubDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<CoachData>().ToTable(nameof(Coaches));
            builder.Entity<ParticipantData>().ToTable(nameof(Participants));
            builder.Entity<TrainingData>().ToTable(nameof(Trainings));
            builder.Entity<TrainingTypeData>().ToTable(nameof(TrainingTypes));
            builder.Entity<CoachOfTrainingData>().ToTable(nameof(CoachesOfTrainings)).HasKey(x => new { x.TrainingId, x.CoachId });
            builder.Entity<ParticipantOfTrainingData>().ToTable(nameof(ParticipantsOfTrainings)).HasKey(x => new { x.TrainingId, x.ParticipantId });
        }
    }
}
