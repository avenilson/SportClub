using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DetailsModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public ParticipantOfTrainingData ParticipantOfTrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParticipantOfTrainingData = await _context.ParticipantsOfTrainings.FirstOrDefaultAsync(m => m.TrainingId == id);

            if (ParticipantOfTrainingData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
