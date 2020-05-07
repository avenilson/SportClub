using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Facade.TrainingType;

namespace SportClub.Pages.TrainingType
{
    public abstract class TrainingTypesPage: CommonPage<ITrainingTypesRepository, Domain.TrainingType.TrainingType, TrainingTypeView, TrainingTypeData>
    {
        protected internal TrainingTypesPage(ITrainingTypesRepository r) : base(r)
        {
            PageTitle = "Training Types";
        }
        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/TrainingType/TrainingTypes";

        public override Domain.TrainingType.TrainingType ToObject(TrainingTypeView view)
        {
            return TrainingTypeViewFactory.Create(view);
        }

        public override TrainingTypeView ToView(Domain.TrainingType.TrainingType obj)
        {
            return TrainingTypeViewFactory.Create(obj);
        }
    }
}
