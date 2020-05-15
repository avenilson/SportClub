using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Tests.Facade.Participant
{
    [TestClass]
    public class ParticipantViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(ParticipantViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<ParticipantView>();
            var data = ParticipantViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<ParticipantData>();
            var view = ParticipantViewFactory.Create(new SportClub.Domain.Participant.Participant(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
