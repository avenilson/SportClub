using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Participant;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DetailsModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public ParticipantData ParticipantData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParticipantData = await _context.Participants.FirstOrDefaultAsync(m => m.Id == id);

            if (ParticipantData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
