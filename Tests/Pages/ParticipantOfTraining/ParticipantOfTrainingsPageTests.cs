using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Facade.ParticipantOfTraining;
using SportClub.Facade.Training;
using SportClub.Pages;
using SportClub.Pages.Participant;
using SportClub.Pages.ParticipantOfTraining;
using SportClub.Tests.Pages.Training;
using ParticipantOfTrainingView = SportClub.Facade.ParticipantOfTraining.ParticipantOfTrainingView;

namespace SportClub.Tests.Pages.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingsPageTests : AbstractClassTests
        <ParticipantOfTrainingsPage, CommonPage<IParticipantOfTrainingsRepository, SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingView, ParticipantOfTrainingData>>
    {
        private class TestClass : ParticipantOfTrainingsPage
        {
            internal TestClass(IParticipantOfTrainingsRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>,
            IParticipantOfTrainingsRepository { } 

        
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
            var r = new ParticipantOfTrainingsPageTests.TestRepository();
            obj = new ParticipantOfTrainingsPageTests.TestClass(r); //annan repository katte
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Participant Of Trainings", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/ParticipantOfTraining/ParticipantOfTrainings", obj.PageUrl);
        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<ParticipantOfTrainingView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<ParticipantOfTrainingData>();
            var view = obj.ToView(new SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }

    }
}
