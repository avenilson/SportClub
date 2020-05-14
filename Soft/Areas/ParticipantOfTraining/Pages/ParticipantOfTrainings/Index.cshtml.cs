using System.Threading.Tasks;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Domain.Training;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
{
    public class IndexModel : ParticipantOfTrainingsPage
    {        
        public IndexModel(IParticipantOfTrainingsRepository r, IParticipantsRepository p, ITrainingsRepository t) : base(r, p, t) { }
       
        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
