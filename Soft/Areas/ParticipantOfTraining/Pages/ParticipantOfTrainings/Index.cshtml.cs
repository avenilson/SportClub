using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Infra;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class IndexModel : ParticipantOfTrainingsPage
    {
        public IndexModel(IParticipantOfTrainingsRepository r) : base(r)
        {
        }

        public IList<ParticipantOfTrainingData> ParticipantOfTrainingData { get; set; }

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
