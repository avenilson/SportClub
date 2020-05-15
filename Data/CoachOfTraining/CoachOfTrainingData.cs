using SportClub.Data.Common;

namespace SportClub.Data.CoachOfTraining
{
    public sealed class CoachOfTrainingData:UniqueEntityData
    {
        public string CoachId { get; set; }
        public string TrainingId { get; set; }
    }
}
