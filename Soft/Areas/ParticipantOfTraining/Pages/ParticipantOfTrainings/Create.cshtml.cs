using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Participant;
using SportClub.Data.Training;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Domain.Training;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class CreateModel : ParticipantOfTrainingsPage
    {
        public CreateModel(IParticipantOfTrainingsRepository r, IParticipantsRepository u,ITrainingsRepository s, IParticipantsRepository p) : base(r,p)
        {
            //Participants = CreateSelectList<Domain.Participant.Participant, ParticipantData>(u);
            //Trainings = CreateSelectList<Domain.Training.Training, TrainingData>(s);
        }
        //public IEnumerable<SelectListItem> Participants { get; }
        //public IEnumerable<SelectListItem> Trainings { get; }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue) //viisin osa koodi measurepagei (parem koht)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
