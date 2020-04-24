using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.CoachOfTraining;
using SportClub.Infra;

namespace SportClub.Soft.Areas.CoachOfTraining.Pages.CoachOfTrainings
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DetailsModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

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
    }
}
