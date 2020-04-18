using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Quantity;
using SportClub.Facade.Quantity;
using SportClub.Pages.Quantity;

namespace SportClub.Soft.Areas.Quantity.Pages.Trainings
{
    public class CreateModel : TrainingsPage
    {
        public CreateModel(ITrainingsRepository r) : base(r)
        {
        }
        public IActionResult OnGet() => Page();

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await db.Add(TrainingViewFactory.Create(Item));

            return RedirectToPage("./Index");
        }
    }
}
