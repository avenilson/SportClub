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
        public override string ItemId => Item.Id;
        
        protected internal override string GetPageUrl() => "/Training/Trainings";
      
        protected internal override Domain.Training.Training ToObject(TrainingView view)
        {
            return TrainingViewFactory.Create(view);
        }

        protected internal override TrainingView ToView(Domain.Training.Training obj)
        {
            return TrainingViewFactory.Create(obj);
        }
    }
}
