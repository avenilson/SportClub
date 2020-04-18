using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Quantity;
using SportClub.Facade.Quantity;
using SportClub.Pages.Quantity;

namespace SportClub.Soft.Areas.Quantity.Pages.Trainings
{
    public class DeleteModel : TrainingsPage
    {
        public DeleteModel(ITrainingsRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            Item = TrainingViewFactory.Create(await db.Get(id));

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null) return NotFound();

            await db.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
