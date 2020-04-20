using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportClub.Facade.Common
{
    public class UniqueEntityView
    {
        [Required]
        public string Id { get; set; }
    }
}
