using SportClub.Data.Participant;
using SportClub.Domain.Participant;

namespace SportClub.Infra.Participant
{
    public sealed class ParticipantsRepository : UniqueEntityRepository<Domain.Participant.Participant, ParticipantData>, IParticipantsRepository
    {
        public ParticipantsRepository(SportClubDbContext c) : base(c, c.Participants) { }

        protected override Domain.Participant.Participant ToDomainObject(ParticipantData d) => new Domain.Participant.Participant(d);
    }
}
