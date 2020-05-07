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
        protected internal TrainingTypesPage(ITrainingTypesRepository r, ITrainingsRepository n) : base(r)
        {
            PageTitle = "Training Types";
            //Names = CreateSelectList<Domain.Training.Training, TrainingData>(n);
        }
        public IEnumerable<SelectListItem> Names { get; }
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
        //public string GetNamesName(string measureId)
        //{
        //    foreach (var m in Names)
        //        if (m.Value == measureId)
        //            return m.Text;

        //    return "Unspecified";
        //}

        //public override string GetPageSubTitle()
        //{
        //    return FixedValue is null
        //        ? base.GetPageSubTitle()
        //        : $"For {GetNamesName(FixedValue)}";
        //}
    }
}
