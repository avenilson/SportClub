using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SportClub.Facade.Common;

namespace SportClub.Facade.Participant
{
    public class ParticipantView: NamedView
    {
        [Required]
        [DisplayName("Participant")]

        public int Age { get; set; }
        public string Address { get; set; }

    }
}
