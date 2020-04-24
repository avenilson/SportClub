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
    public class DeleteModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DeleteModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CoachData = await _context.Coaches.FindAsync(id);

            if (CoachData != null)
            {
                _context.Coaches.Remove(CoachData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
