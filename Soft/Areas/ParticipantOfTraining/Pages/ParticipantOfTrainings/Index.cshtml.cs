using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class IndexModel : ParticipantOfTrainingsPage
    {        
        public IndexModel(IParticipantOfTrainingsRepository r) : base(r) {}
       
        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
