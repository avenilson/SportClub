using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;
using SportClub.Facade.TrainingType;

namespace SportClub.Pages.TrainingType
{
    public abstract class TrainingTypesPage: CommonPage<ITrainingTypesRepository, Domain.TrainingType.TrainingType, TrainingTypeView, TrainingTypeData>
    {
        protected internal TrainingTypesPage(ITrainingTypesRepository r) : base(r) => PageTitle = "Training Types";
        public IEnumerable<SelectListItem> Names { get; }

        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/TrainingType/TrainingTypes";

        public override Domain.TrainingType.TrainingType ToObject(TrainingTypeView view) => TrainingTypeViewFactory.Create(view);

        public override TrainingTypeView ToView(Domain.TrainingType.TrainingType obj) => TrainingTypeViewFactory.Create(obj);
    }
}
