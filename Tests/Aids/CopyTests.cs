using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Tests.Aids {

    [TestClass] public class CopyTests : BaseTests {

        [TestInitialize] public void TestInitialize() {
            type = typeof(Copy);
        }

        [TestMethod] public void MembersTest() {
            var x = GetRandom.Object<ParticipantData>();
            var y = GetRandom.Object<ParticipantView>();
            TestArePropertyValuesEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
    }
}
