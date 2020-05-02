using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Pages.Training;

namespace SportClub.Soft.Areas.Training.Pages.Trainings
{
    public class DetailsModel : TrainingsPage
    {
        public DetailsModel(ITrainingsRepository r, ITrainingTypesRepository t) : base(r, t) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
