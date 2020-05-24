using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Aids;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.CoachOfTraining;

namespace SportClub.Infra.CoachOfTraining
{
    public sealed class CoachOfTrainingsRepository : UniqueEntityRepository<Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>, ICoachOfTrainingsRepository
    {
        public CoachOfTrainingsRepository(SportClubDbContext c) : base(c, c?.CoachesOfTrainings) { }
        protected override Domain.CoachOfTraining.CoachOfTraining ToDomainObject(CoachOfTrainingData d) 
            => new Domain.CoachOfTraining.CoachOfTraining(d);
    }
}
