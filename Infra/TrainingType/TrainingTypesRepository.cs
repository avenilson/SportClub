using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;

namespace SportClub.Infra.TrainingType
{
    public sealed class TrainingTypesRepository : UniqueEntityRepository<Domain.TrainingType.TrainingType, TrainingTypeData>, ITrainingTypesRepository
    {
        public TrainingTypesRepository(SportClubDbContext c) : base(c, c.TrainingTypes) { }

        protected override Domain.TrainingType.TrainingType ToDomainObject(TrainingTypeData d) => new Domain.TrainingType.TrainingType(d);
    }
}
