using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class EditModel : ParticipantOfTrainingsPage
    {
        public EditModel(IParticipantOfTrainingsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);

            return Redirect(IndexUrl);
        }      
    }
}
