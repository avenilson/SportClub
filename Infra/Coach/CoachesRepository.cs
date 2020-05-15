using SportClub.Data.Coach;
using SportClub.Domain.Coach;

namespace SportClub.Infra.Coach
{
    public sealed class CoachesRepository : UniqueEntityRepository<Domain.Coach.Coach, CoachData>, ICoachesRepository
    {
        public CoachesRepository(SportClubDbContext c) : base(c, c.Coaches) { }
        protected override Domain.Coach.Coach ToDomainObject(CoachData d) => new Domain.Coach.Coach(d);
    }
}
