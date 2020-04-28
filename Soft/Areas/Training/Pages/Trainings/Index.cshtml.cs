using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Infra;
using SportClub.Pages.Training;

namespace SportClub.Soft.Areas.Training.Pages.Trainings
{
    public class IndexModel : TrainingsPage
    {
        public IndexModel(ITrainingsRepository r) : base(r)
        {
        }

        public IList<TrainingData> TrainingData { get; set; }

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
