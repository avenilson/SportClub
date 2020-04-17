using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Facade.Quantity;
using SportClub.Soft.Data;

namespace SportClub.Soft
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Soft.Data.ApplicationDbContext _context;

        public DetailsModel(SportClub.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public TrainingView TrainingView { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrainingView = await _context.Trainings.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingView == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
