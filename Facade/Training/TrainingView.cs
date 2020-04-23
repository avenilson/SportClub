﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.Training
{
    public sealed class TrainingView:NamedView
    {
        [Required]
        [DisplayName("Training")]

        public int Duration { get; set; }
        public string Definition { get; set; }
        public int ParticipantsCount { get; set; }

    }
}
