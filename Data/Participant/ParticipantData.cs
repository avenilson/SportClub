using System;
using System.Collections.Generic;
using System.Text;
using SportClub.Data.Common;

namespace SportClub.Data.Participant
{
    public class ParticipantData: NamedEntityData
    {
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
