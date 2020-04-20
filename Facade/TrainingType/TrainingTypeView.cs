using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SportClub.Facade.Common;

namespace SportClub.Facade.TrainingType
{
    public class TrainingTypeView:UniqueEntityView
    {
        [Required]
        [DisplayName("Training Type")]
        public string Type { get; set; }
    }
}
