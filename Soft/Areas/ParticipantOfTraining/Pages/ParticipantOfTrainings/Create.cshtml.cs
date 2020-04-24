using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Infra;

namespace SportClub.Soft.Areas.ParticipantOfTraining.Pages.ParticipantOfTrainings
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
        public ParticipantOfTrainingData ParticipantOfTrainingData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ParticipantsOfTrainings.Add(ParticipantOfTrainingData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
