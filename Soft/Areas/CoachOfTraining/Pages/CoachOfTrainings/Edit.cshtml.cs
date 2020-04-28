using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.CoachOfTraining;

namespace SportClub.Soft.Areas.CoachOfTraining.Pages.CoachOfTrainings
{
    public class EditModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public EditModel(SportClub.Infra.SportClubDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CoachOfTrainingData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoachOfTrainingDataExists(CoachOfTrainingData.TrainingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CoachOfTrainingDataExists(string id)
        {
            return _context.CoachesOfTrainings.Any(e => e.TrainingId == id);
        }
    }
}
