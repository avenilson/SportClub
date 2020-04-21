using SportClub.Data.Common;

namespace SportClub.Data.CoachOfTraining
{
    public sealed class CoachOfTrainingData:NamedEntityData
    {
        public string TrainingId { get; set; }
        public string CoachId { get; set; }
    }
}
