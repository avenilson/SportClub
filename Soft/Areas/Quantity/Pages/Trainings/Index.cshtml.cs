using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Domain.Quantity;
using SportClub.Facade.Quantity;
using SportClub.Pages.Quantity;

namespace SportClub.Soft.Areas.Quantity.Pages.Trainings
{
    public class IndexModel : TrainingsPage
    {
        public IndexModel(ITrainingsRepository r) : base(r)
        {
        }

        public async Task OnGetAsync()
        {
            var l = await data.Get();
            Items = new List<TrainingView>();
            foreach (var e in l)
            {
                Items.Add(TrainingViewFactory.Create(e));
            }
        }
    }
}
