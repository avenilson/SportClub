using SportClub.Data.Coach;
using SportClub.Domain.Coach;
using SportClub.Facade.Coach;

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