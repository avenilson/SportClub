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
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<CoachData> CoachData { get;set; }

        public async Task OnGetAsync()
        {
            CoachData = await _context.Coaches.ToListAsync();
        }
    }
}
