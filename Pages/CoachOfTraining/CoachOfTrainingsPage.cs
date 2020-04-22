using SportClub.Data.CoachOfTraining;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.CoachOfTraining;

namespace SportClub.Pages.CoachOfTraining
{
    public abstract class CoachOfTrainingsPage : CommonPage<ICoachOfTrainingsRepository, Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>
    {
        protected internal CoachOfTrainingsPage(ICoachOfTrainingsRepository r) : base(r)
        {
            PageTitle = "Coach of Trainings";
        }

        public override string ItemId => Item.Id;

        protected internal override string GetPageUrl() => "/CoachOfTraining/CoachOfTrainings";

        protected internal override Domain.CoachOfTraining.CoachOfTraining ToObject(CoachOfTrainingView view)
        {
            return CoachOfTrainingViewFactory.Create(view);
        }

        protected internal override CoachOfTrainingView ToView(Domain.CoachOfTraining.CoachOfTraining obj)
        {
            return CoachOfTrainingViewFactory.Create(obj);
        }

    }

}