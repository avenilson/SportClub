using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.TrainingType;
using SportClub.Pages.TrainingType;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class DetailsModel : TrainingTypesPage
    {
        public DetailsModel(ITrainingTypesRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
