using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Pages.Training;

namespace SportClub.Soft.Areas.Training.Pages.Trainings
{
    public class CreateModel : TrainingsPage
    {
        public CreateModel(ITrainingsRepository r, ITrainingTypesRepository t) : base(r, t) { }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
