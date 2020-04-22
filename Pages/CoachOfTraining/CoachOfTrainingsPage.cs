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

        protected internal override string getPageUrl() => "/CoachOfTraining/CoachOfTrainings";

        protected internal override Domain.CoachOfTraining.CoachOfTraining toObject(CoachOfTrainingView view)
        {
            return CoachOfTrainingViewFactory.Create(view);
        }

        protected internal override CoachOfTrainingView toView(Domain.CoachOfTraining.CoachOfTraining obj)
        {
            return CoachOfTrainingViewFactory.Create(obj);
        }

    }

}