using System;
using System.Collections.Generic;
using System.Text;
using SportClub.Data.TrainingParticipant;
using SportClub.Domain.Common;

namespace SportClub.Domain.TrainingParticipant
{
    public sealed class TrainingParticipant : Entity<TrainingParticipantData>
    {
        public TrainingParticipant() : this(null) { }
        public TrainingParticipant(TrainingParticipantData data) : base(data) { }

    }
}
