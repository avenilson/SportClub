using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SportClub.Facade.Common;

namespace SportClub.Facade.Training
{
    public class TrainingView:NamedView
    {
        [Required]
        [DisplayName("Training")]

        public int Duration { get; set; }
        public string Definition { get; set; }
        public int MaxParticipants { get; set; }

    }
}
