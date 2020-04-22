using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Aids;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.CoachOfTraining;

namespace SportClub.Infra.CoachOfTraining
{
    public sealed class CoachOfTrainingsRepository : PaginatedRepository<Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>, ICoachOfTrainingsRepository
    {

        public CoachOfTrainingsRepository() : this(null) { }
        public CoachOfTrainingsRepository(SportClubDbContext c) : base(c, c?.CoachesOfTrainings) { }

        protected internal override Domain.CoachOfTraining.CoachOfTraining ToDomainObject(CoachOfTrainingData d) => new Domain.CoachOfTraining.CoachOfTraining(d);

        protected override async Task<CoachOfTrainingData> getData(string id)
        {
            var coachId = GetString.Head(id);
            var trainingId = GetString.Tail(id);

            return await dbSet.SingleOrDefaultAsync(x => x.CoachId == coachId && x.TrainingId == trainingId);
        }

        protected override string getId(Domain.CoachOfTraining.CoachOfTraining obj)
        {
            return obj?.Data is null ? string.Empty : $"{obj.Data.CoachId}.{obj.Data.TrainingId}";
        }
    }
}
