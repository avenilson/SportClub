using SportClub.Data.Quantity;
using SportClub.Domain.Common;

namespace SportClub.Domain.Quantity
{
    public class Training: Entity<TrainingData>
    {
        public Training(TrainingData data) : base(data)
        {
        }
    }
}
