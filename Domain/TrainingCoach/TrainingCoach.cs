using SportClub.Data.TrainingCoach;
using SportClub.Domain.Common;

namespace SportClub.Domain.TrainingCoach
{
    public sealed class TrainingCoach : Entity<TrainingCoachData>
    {
        public TrainingCoach() : this(null) { }
        public TrainingCoach(TrainingCoachData data) : base(data) { }
    }
}
