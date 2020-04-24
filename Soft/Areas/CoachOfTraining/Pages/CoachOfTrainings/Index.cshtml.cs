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
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<CoachOfTrainingData> CoachOfTrainingData { get;set; }

        public async Task OnGetAsync()
        {
            CoachOfTrainingData = await _context.CoachesOfTrainings.ToListAsync();
        }
    }
}
