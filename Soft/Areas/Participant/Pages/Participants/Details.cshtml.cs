using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Participant;
using SportClub.Pages.Participant;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class DetailsModel : ParticipantsPage
    {
        public DetailsModel(IParticipantsRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);    

            return Page();
        }
    }
}
