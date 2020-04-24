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
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<ParticipantOfTrainingData> ParticipantOfTrainingData { get;set; }

        public async Task OnGetAsync()
        {
            ParticipantOfTrainingData = await _context.ParticipantsOfTrainings.ToListAsync();
        }
    }
}
