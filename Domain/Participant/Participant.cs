using SportClub.Data.Participant;
using SportClub.Domain.Common;

namespace SportClub.Domain.Participant
{
    public sealed class Participant: Entity<ParticipantData>
    {
        public Participant() : this(null) { }
        public Participant(ParticipantData data) : base(data) { }
    }
}
