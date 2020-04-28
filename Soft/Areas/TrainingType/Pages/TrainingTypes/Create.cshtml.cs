using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportClub.Data.TrainingType;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class CreateModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public CreateModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TrainingTypeData TrainingTypeData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TrainingTypes.Add(TrainingTypeData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
