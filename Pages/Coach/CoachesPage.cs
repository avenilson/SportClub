﻿using SportClub.Data.Coach;
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

        public override string ItemId => Item.Id;

        protected internal override string getPageUrl() => "/Coach/Coaches";

        protected internal override Domain.Coach.Coach toObject(CoachView view)
        {
            return CoachViewFactory.Create(view);
        }

        protected internal override CoachView toView(Domain.Coach.Coach obj)
        {
            return CoachViewFactory.Create(obj);
        }

    }

}