using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Coach;
using SportClub.Infra;

namespace SportClub.Soft.Areas.Coach.Pages.Coaches
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DetailsModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public CoachData CoachData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CoachData = await _context.Coaches.FirstOrDefaultAsync(m => m.Id == id);

            if (CoachData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
