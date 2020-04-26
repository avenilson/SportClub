using System;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;

namespace SportClub.Pages.Training
{
    public abstract class TrainingsPage: CommonPage<ITrainingsRepository, Domain.Training.Training, TrainingView, TrainingData>
    {
        protected internal TrainingsPage(ITrainingsRepository r): base(r)
        {
            PageTitle = "Trainings";
           
        }
        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/Training/Trainings";

        public override Domain.Training.Training ToObject(TrainingView view)
        {
            return TrainingViewFactory.Create(view);
        }

        public override TrainingView ToView(Domain.Training.Training obj)
        {
            return TrainingViewFactory.Create(obj);
        }
    }
}
