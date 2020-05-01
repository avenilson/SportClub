using SportClub.Data.Common;

namespace SportClub.Data.CoachOfTraining
{
    public sealed class CoachOfTrainingData:NamedEntityData
    {
        public string CoachId { get; set; }

        public string TrainingId { get; set; }
    }
}
