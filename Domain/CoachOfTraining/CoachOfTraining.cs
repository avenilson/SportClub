using SportClub.Data.TrainingCoach;
using SportClub.Domain.Common;

namespace SportClub.Domain.CoachOfTraining
{
    public sealed class CoachOfTraining : Entity<CoachOfTrainingData>
    {
        public CoachOfTraining() : this(null) { }
        public CoachOfTraining(TrainingCoachData data) : base(data) { }

        
    }
}
