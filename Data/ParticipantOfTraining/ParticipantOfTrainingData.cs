using SportClub.Data.Common;

namespace SportClub.Data.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingData:NamedEntityData
    {
        public string TrainingId { get; set; }
        public string ParticipantId { get; set; }

    }
}
