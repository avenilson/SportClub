using SportClub.Data.Training;
using SportClub.Domain.Common;

namespace SportClub.Domain.Training
{
    public sealed class Training : Entity<TrainingData>
    {
        public Training() : this(null) { }
        public Training(TrainingData data) : base(data) { }
    }
}
