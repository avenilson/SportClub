using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Common;

namespace SportClub.Domain.CoachOfTraining
{
    public sealed class CoachOfTraining : Entity<CoachOfTrainingData>
    {
        public CoachOfTraining() : this(null) { }
        public CoachOfTraining(CoachOfTrainingData data) : base(data) { }

    }
}
