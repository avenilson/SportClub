using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportClub.Facade.Common
{
    public class NamedView: UniqueEntityView
    {
        [Required]
        public string Name { get; set; }
    }
}
