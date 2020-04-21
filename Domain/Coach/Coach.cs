using SportClub.Data.Coach;
using SportClub.Data.Participant;
using SportClub.Domain.Common;

namespace SportClub.Domain.Coach
{
    public sealed class Coach : Entity<CoachData>
    {
        public Coach() : this(null) { }
        public Coach(CoachData data) : base(data) { }
    }
}
