using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.ParticipantOfTraining;

namespace SportClub.Infra.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingsRepository : PaginatedRepository<Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>, IParticipantOfTrainingsRepository
    {
        public ParticipantOfTrainingsRepository() : this(null) { }
        public ParticipantOfTrainingsRepository(SportClubDbContext c) : base(c, c?.ParticipantsOfTrainings) { }

        protected override Domain.ParticipantOfTraining.ParticipantOfTraining ToDomainObject(ParticipantOfTrainingData d) 
            => new Domain.ParticipantOfTraining.ParticipantOfTraining(d);

        protected override async Task<ParticipantOfTrainingData> GetData(string id) 
            => await dbSet.SingleOrDefaultAsync(x => x.Id == id);

        protected override string GetId(Domain.ParticipantOfTraining.ParticipantOfTraining obj) 
            => obj?.Data is null ? string.Empty : $"{obj.Data.ParticipantId}.{obj.Data.TrainingId}";
    }
}
