﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.TrainingType;
using SportClub.Infra;

namespace SportClub.Soft.Areas.TrainingType.Pages.TrainingTypes
{
    public class DetailsModel : PageModel
    {
        private readonly SportClub.Infra.SportClubDbContext _context;

        public DetailsModel(SportClub.Infra.SportClubDbContext context)
        {
            _context = context;
        }

        public TrainingTypeData TrainingTypeData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrainingTypeData = await _context.TrainingTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingTypeData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
