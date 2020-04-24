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
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<TrainingData> TrainingData { get;set; }

        public async Task OnGetAsync()
        {
            TrainingData = await _context.Trainings.ToListAsync();
        }
    }
}
