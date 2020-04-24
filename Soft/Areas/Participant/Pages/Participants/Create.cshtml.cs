﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Participant;
using SportClub.Infra;

namespace SportClub.Soft.Areas.Participant.Pages.Participants
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
        public ParticipantData ParticipantData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Participants.Add(ParticipantData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
