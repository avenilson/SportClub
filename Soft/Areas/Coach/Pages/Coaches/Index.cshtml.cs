using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.Coach;
using SportClub.Domain.Coach;
using SportClub.Pages.Coach;

namespace SportClub.Soft.Areas.Coach.Pages.Coaches
{
    public class IndexModel : CoachesPage
    {
        public IndexModel(ICoachesRepository r) : base(r) { }
        public IList<CoachData> CoachData { get;set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
