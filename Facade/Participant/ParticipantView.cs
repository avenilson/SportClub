﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.Participant
{
    public sealed class ParticipantView: NamedView
    {
        [Required]
        [DisplayName("Participant")]

        public string Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Address { get; set; }

    }
}
