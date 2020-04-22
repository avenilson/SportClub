using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Domain.Coach;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Facade.Common;
using SportClub.Facade.Training;
using SportClub.Facade.TrainingType;

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
