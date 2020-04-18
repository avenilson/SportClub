using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Domain.Quantity;
using SportClub.Facade.Quantity;
using SportClub.Pages.Quantity;

namespace SportClub.Soft.Areas.Quantity.Pages.Trainings
{
    public class IndexModel : TrainingsPage
    {
        public string SearchString;
        public IndexModel(ITrainingsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            db.SortOrder = sortOrder;
            SearchString = searchString;
            db.SearchString = SearchString;
            var l = await db.Get();
            Items = new List<TrainingView>();
            foreach (var e in l) Items.Add(TrainingViewFactory.Create(e));
        }

        public string DateSort { get; set; }

        public string NameSort { get; set; }
    }
}
