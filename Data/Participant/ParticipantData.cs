using SportClub.Data.Common;

namespace SportClub.Data.Participant
{
    public sealed class ParticipantData: NamedEntityData
    {
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
