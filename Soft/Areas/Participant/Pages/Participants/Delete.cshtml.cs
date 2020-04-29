using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Participant;
using SportClub.Pages.Participant;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class DeleteModel : ParticipantsPage
    {
        public DeleteModel(IParticipantsRepository r) : base(r) { }
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
