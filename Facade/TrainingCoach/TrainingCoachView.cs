using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SportClub.Facade.Common;

namespace SportClub.Facade.TrainingCoach
{
    public class TrainingCoachView: NamedView
    {
        [Required]
        [DisplayName("Training")]

        public string TrainingId { get; set; }

        [Required]
        [DisplayName("Coach")]

        public string CoachId { get; set; }

        public string GetId()
        {
            return $"{CoachId}.{TrainingId}";
        }
    }
}
