﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SportClub.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportClub.Domain.Quantity;


namespace SportClub.Pages.Quantity
{
    public abstract class TrainingsPage: PageModel
    {
        protected internal readonly ITrainingsRepository data;

        protected internal TrainingsPage(ITrainingsRepository r) => data = r;

       
        [BindProperty]
        public TrainingView Item { get; set; } 
        public IList<TrainingView> Items { get; set; }
    
    }
}
