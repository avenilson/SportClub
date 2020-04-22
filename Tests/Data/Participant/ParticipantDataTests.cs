using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Common;
using SportClub.Data.Participant;

namespace SportClub.Tests.Data.Participant
{
    [TestClass]
    public class ParticipantDataTests : SealedClassTests<ParticipantData, NamedEntityData>
    {
        [TestMethod]
        public void AgeTest()
        {
            IsNullableProperty(() => obj.Age, x => obj.Age = x);
        }
        [TestMethod]
        public void AddressTest()
        {
            IsNullableProperty(() => obj.Address, x => obj.Address = x);
        }
    }
}
