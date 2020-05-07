using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Coach;
using SportClub.Data.Training;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Domain.Training;
using SportClub.Pages.CoachOfTraining;

namespace SportClub.Soft.Areas.CoachOfTraining.Pages.CoachOfTrainings
{
    public class CreateModel : CoachOfTrainingsPage
    {
        public CreateModel(ICoachOfTrainingsRepository r,
            ICoachesRepository u, ITrainingsRepository s, ICoachesRepository c) : base(r,c) { 
           // Coaches = CreateSelectList<Domain.Coach.Coach, CoachData>(u);
           // Trainings = CreateSelectList<Domain.Training.Training, TrainingData>(s);
        }

        //public IEnumerable<SelectListItem> Coaches { get; }

        //public IEnumerable<SelectListItem> Trainings { get; }


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
