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
    public class IndexModel : PageModel
    {
        private readonly SportClub.Soft.Data.ApplicationDbContext _context;

        public IndexModel(SportClub.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TrainingView> TrainingView { get;set; }

        public async Task OnGetAsync()
        {
            TrainingView = await _context.Trainings.ToListAsync();
        }
    }
}
