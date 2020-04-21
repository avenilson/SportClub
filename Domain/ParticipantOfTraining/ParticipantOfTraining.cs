using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.Common;

namespace SportClub.Domain.ParticipantOfTraining
{
    public sealed class ParticipantOfTraining : Entity<ParticipantOfTrainingData>
    {
        public ParticipantOfTraining() : this(null) { }
        public ParticipantOfTraining(ParticipantOfTrainingData data) : base(data) { }

    }
}
