using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Pages.TrainingType;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class DeleteModel : TrainingTypesPage
    {
        public DeleteModel(ITrainingTypesRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
