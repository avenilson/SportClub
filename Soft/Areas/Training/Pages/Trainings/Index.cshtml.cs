using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Pages.Training;

namespace SportClub.Soft.Areas.Training.Pages.Trainings
{
    public class IndexModel : TrainingsPage
    {
        public IndexModel(ITrainingsRepository r, ITrainingTypesRepository t) : base(r, t) { }

        public IList<TrainingData> TrainingData { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);

        }
    }
}
