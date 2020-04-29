using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Coach;
using SportClub.Pages.Coach;

namespace SportClub.Soft.Areas.Coach.Pages.Coaches
{
    public class DetailsModel : CoachesPage
    {
        public DetailsModel(ICoachesRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
