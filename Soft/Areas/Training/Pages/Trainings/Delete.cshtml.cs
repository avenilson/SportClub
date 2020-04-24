using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Training;
using SportClub.Infra;

namespace SportClub.Soft.Areas.Training.Pages.Trainings
{
    public class DeleteModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DeleteModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TrainingData TrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrainingData = await _context.Trainings.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingData == null)
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

            TrainingData = await _context.Trainings.FindAsync(id);

            if (TrainingData != null)
            {
                _context.Trainings.Remove(TrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
