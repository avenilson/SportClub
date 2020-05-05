using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Pages.CoachOfTraining;

namespace SportClub.Soft.Areas.CoachOfTraining.Pages.CoachOfTrainings
{
    public class IndexModel : CoachOfTrainingsPage
    {
        public IndexModel(ICoachOfTrainingsRepository r, ICoachesRepository c) : base(r,c)
        {
        }

        public async Task OnGetAsync(string sortOrder, string id,
            string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);


        }
    }
}
