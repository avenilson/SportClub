using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Quantity;
using SportClub.Facade.Quantity;
using SportClub.Pages.Quantity;

namespace SportClub.Soft.Areas.Quantity.Pages.Trainings
{
    public class EditModel : TrainingsPage
    {
        public EditModel(ITrainingsRepository r) : base(r)
        {
        }
        
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            Item = TrainingViewFactory.Create(await db.Get(id));

            if (Item == null) return NotFound();
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await db.Update(TrainingViewFactory.Create(Item));

            return RedirectToPage("./Index");
        }
    }
}
