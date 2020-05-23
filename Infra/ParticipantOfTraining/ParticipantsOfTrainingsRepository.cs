using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.ParticipantOfTraining;

namespace SportClub.Infra.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingsRepository : UniqueEntityRepository<Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>, IParticipantOfTrainingsRepository
    {
        public ParticipantOfTrainingsRepository(SportClubDbContext c) : base(c, c?.ParticipantsOfTrainings) { }

        protected override Domain.ParticipantOfTraining.ParticipantOfTraining ToDomainObject(ParticipantOfTrainingData d) 
            => new Domain.ParticipantOfTraining.ParticipantOfTraining(d);
    }
}
