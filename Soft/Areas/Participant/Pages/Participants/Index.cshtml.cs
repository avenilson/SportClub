using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Participant;
using SportClub.Infra;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class IndexModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public IndexModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IList<ParticipantData> ParticipantData { get;set; }

        public async Task OnGetAsync()
        {
            ParticipantData = await _context.Participants.ToListAsync();
        }
    }
}
