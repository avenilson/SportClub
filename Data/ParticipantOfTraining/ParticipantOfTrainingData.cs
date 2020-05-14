using SportClub.Data.Common;

namespace SportClub.Data.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingData:UniqueEntityData
    {
        public string TrainingId { get; set; }
        public string ParticipantId { get; set; }

    }
}
