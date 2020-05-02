using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Common;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Domain.Common;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Facade.Training;

namespace SportClub.Pages.Training
{
    public abstract class TrainingsPage: CommonPage<ITrainingsRepository, Domain.Training.Training, TrainingView, TrainingData>
    {
        protected internal TrainingsPage(ITrainingsRepository r, ITrainingTypesRepository t): base(r)
        {
            PageTitle = "Trainings";
            Types = CreateSelectList<Domain.TrainingType.TrainingType, TrainingTypeData>(t);
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
        public IEnumerable<SelectListItem> Types { get; }

        protected static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : NamedEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Name, t.Data.Id)).ToList();
        }
    }
}
