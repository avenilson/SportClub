using SportClub.Data.Training;
using SportClub.Domain.Training;

namespace SportClub.Infra.Training
{
    public sealed class TrainingsRepository : UniqueEntityRepository<Domain.Training.Training, TrainingData>, ITrainingsRepository
    {
        public TrainingsRepository(SportClubDbContext c) : base(c, c.Trainings) { }

        protected internal override Domain.Training.Training ToDomainObject(TrainingData d) => new Domain.Training.Training(d);
    }
}
