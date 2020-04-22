using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;
using SportClub.Facade.TrainingType;

namespace SportClub.Pages.TrainingType
{
    public abstract class TrainingTypesPage: CommonPage<ITrainingTypesRepository, Domain.TrainingType.TrainingType, TrainingTypeView, TrainingTypeData>
    {
        protected internal TrainingTypesPage(ITrainingTypesRepository r): base(r)
        {
            PageTitle = "Training Types";
           
        }
        public override string ItemId => Item.Id;
        
        protected internal override string GetPageUrl() => "/TrainingType/TrainingTypes";
      
        protected internal override Domain.TrainingType.TrainingType ToObject(TrainingTypeView view)
        {
            return TrainingTypeViewFactory.Create(view);
        }

        protected internal override TrainingTypeView ToView(Domain.TrainingType.TrainingType obj)
        {
            return TrainingTypeViewFactory.Create(obj);
        }
    }
}
