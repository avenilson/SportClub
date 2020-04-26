using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.CoachOfTraining;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Facade.Coach;
using SportClub.Facade.Participant;
using SportClub.Pages;
using SportClub.Pages.Participant;
using SportClub.Tests.Pages.Coach;

namespace SportClub.Tests.Pages.Participant
{
    [TestClass]
    public class ParticipantsPageTests : AbstractClassTests
        <ParticipantsPage, CommonPage<IParticipantsRepository, SportClub.Domain.Participant.Participant, ParticipantView, ParticipantData>>
    {
        private class TestClass : ParticipantsPage
        {
            internal TestClass(IParticipantsRepository r) : base(r) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Participant.Participant, ParticipantData>,
            IParticipantsRepository { } 
       
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
            var r = new ParticipantsPageTests.TestRepository();
            obj = new ParticipantsPageTests.TestClass(r); //annan repository katte
        }
        
        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<ParticipantView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Participants", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Participant/Participants", obj.PageUrl);
        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<ParticipantView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<ParticipantData>();
            var view = obj.ToView(new SportClub.Domain.Participant.Participant(data));
            TestArePropertyValuesEqual(view, data);
        }

    }
}
