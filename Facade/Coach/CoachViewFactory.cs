using System;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Domain.Coach;

namespace SportClub.Facade.Coach
{
    public static class CoachViewFactory
    {
        public static Domain.Coach.Coach Create(CoachView view)
        {
            var d = new CoachData();
            Copy.Members(view, d);

            return new Domain.Coach.Coach(d);
        }

        public static CoachView Create(Domain.Coach.Coach o)
        {
            var v = new CoachView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
