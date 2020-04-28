using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Participant;
using SportClub.Domain.Participant;
using SportClub.Infra;
using SportClub.Pages.Participant;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
{
    public class IndexModel : ParticipantsPage
    {
        public IndexModel(IParticipantsRepository r) : base(r)
        {
        }

        public IList<ParticipantData> ParticipantData { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);

        }
    }
}
