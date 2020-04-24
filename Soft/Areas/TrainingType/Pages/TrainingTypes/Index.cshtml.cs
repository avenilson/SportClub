using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.TrainingType;
using SportClub.Infra;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<TrainingTypeData> TrainingTypeData { get;set; }

        public async Task OnGetAsync()
        {
            TrainingTypeData = await _context.TrainingTypes.ToListAsync();
        }
    }
}
