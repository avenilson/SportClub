using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Infra;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class DeleteModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DeleteModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParticipantOfTrainingData = await _context.ParticipantsOfTrainings.FindAsync(id);

            if (ParticipantOfTrainingData != null)
            {
                _context.ParticipantsOfTrainings.Remove(ParticipantOfTrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
