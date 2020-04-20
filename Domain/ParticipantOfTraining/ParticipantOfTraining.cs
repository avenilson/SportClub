using SportClub.Data.TrainingParticipant;
using SportClub.Domain.Common;

namespace SportClub.Domain.ParticipantOfTraining
{
    public sealed class ParticipantOfTraining : Entity<ParticipantOfTrainingData>
    {
        public ParticipantOfTraining() : this(null) { }
        public ParticipantOfTraining(TrainingParticipantData data) : base(data) { }

    }
}
