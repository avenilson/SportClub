using System.Collections.Generic;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.Coach;
using SportClub.Facade.CoachOfTraining;

namespace SportClub.Pages.Coach
{
    public abstract class CoachesPage : CommonPage<ICoachesRepository, Domain.Coach.Coach, CoachView, CoachData>
    {
        protected internal CoachesPage(ICoachesRepository r) : base(r)
        {
            PageTitle = "Coaches";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/Coach/Coaches";

        public override Domain.Coach.Coach ToObject(CoachView view)
        {
            return CoachViewFactory.Create(view);
        }

        public override CoachView ToView(Domain.Coach.Coach obj)
        {
            return CoachViewFactory.Create(obj);
        }


    }
}