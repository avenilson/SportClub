using SportClub.Data.TrainingType;
using SportClub.Domain.Common;

namespace SportClub.Domain.TrainingType
{
    public sealed class TrainingType : Entity<TrainingTypeData>
    {
        public TrainingType() : this(null) { }
        public TrainingType(TrainingTypeData data) : base(data) { }

    }
}
