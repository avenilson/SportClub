using SportClub.Data.Common;

namespace SportClub.Data.Training
{
    public sealed class TrainingData:NamedEntityData
    {
        public string Definition { get; set; }
        public string Duration { get; set; }
        public string ParticipantsCount { get; set; }
    }
}
