using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Participant;
using SportClub.Pages.Participant;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class CreateModel : ParticipantsPage
    {
        public CreateModel(IParticipantsRepository r) : base(r) { }

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
