using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Participant;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.Participant
{
    [TestClass] 
    public class ParticipantTests: SealedClassTests<SportClub.Domain.Participant.Participant, Entity<ParticipantData>> { }
}
