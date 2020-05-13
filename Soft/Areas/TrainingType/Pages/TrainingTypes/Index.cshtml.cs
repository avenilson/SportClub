using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;
using SportClub.Pages.TrainingType;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class IndexModel : TrainingTypesPage
    {
        public IndexModel(ITrainingTypesRepository r) : base(r)
        {
        }

        public IList<TrainingTypeData> TrainingTypeData { get; set; }

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
