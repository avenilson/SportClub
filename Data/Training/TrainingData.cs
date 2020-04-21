using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using SportClub.Data.Common;

namespace SportClub.Data.Training
{
    public sealed class TrainingData:NamedEntityData
    {
        public string Definition { get; set; }
        public int Duration { get; set; }
        public int MaxParticipants { get; set; }
    }
}
