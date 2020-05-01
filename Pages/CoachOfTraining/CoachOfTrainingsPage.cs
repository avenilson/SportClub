using SportClub.Data.CoachOfTraining;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.CoachOfTraining;

namespace SportClub.Pages.CoachOfTraining
{
    public abstract class CoachOfTrainingsPage : CommonPage<ICoachOfTrainingsRepository, Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>
    {
        protected internal CoachOfTrainingsPage(ICoachOfTrainingsRepository r) : base(r)
        {
            PageTitle = "Coach Of Trainings";
        }
        public override string ItemId 
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.CoachId}.{Item.TrainingId}";
            }
        }

        public override string GetPageUrl() => "/CoachOfTraining/CoachOfTrainings";

        public override Domain.CoachOfTraining.CoachOfTraining ToObject(CoachOfTrainingView view)
        {
            return CoachOfTrainingViewFactory.Create(view);
        }

        public override CoachOfTrainingView ToView(Domain.CoachOfTraining.CoachOfTraining obj)
        {
            return CoachOfTrainingViewFactory.Create(obj);
        }

    }

}