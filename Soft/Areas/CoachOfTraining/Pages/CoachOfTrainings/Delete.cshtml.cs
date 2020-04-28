using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.CoachOfTraining;

namespace SportClub.Soft.Areas.CoachOfTraining.Pages.CoachOfTrainings
{
    public class DeleteModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DeleteModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CoachOfTrainingData CoachOfTrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CoachOfTrainingData = await _context.CoachesOfTrainings.FirstOrDefaultAsync(m => m.TrainingId == id);

            if (CoachOfTrainingData == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CoachOfTrainingData = await _context.CoachesOfTrainings.FindAsync(id);

            if (CoachOfTrainingData != null)
            {
                _context.CoachesOfTrainings.Remove(CoachOfTrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
