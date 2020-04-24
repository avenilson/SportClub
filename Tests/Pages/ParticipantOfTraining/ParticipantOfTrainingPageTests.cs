using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Facade.ParticipantOfTraining;
using SportClub.Pages;
using SportClub.Pages.Participant;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Tests.Pages.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingPageTests : AbstractClassTests
        <ParticipantsPage, CommonPage<IParticipantOfTrainingsRepository, SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingView, ParticipantOfTrainingData>>
    {
        private class TestClass : ParticipantOfTrainingsPage
        {
            internal TestClass(IParticipantOfTrainingsRepository r) : base(r)
            {
            }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>,
            IParticipantOfTrainingsRepository { } 

        //[TestMethod]
        //public void ItemIdTest()
        //{
        //    var item = GetRandom.Object<ParticipantOfTrainingView>();
        //    obj.Item = item;
        //    Assert.AreEqual(item.Id, obj.ItemId);
        //    obj.Item = null;
        //    Assert.AreEqual(string.Empty, obj.ItemId);
        //}

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Participant Of Trainings", obj.PageTitle);

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/ParticipantOfTraining/ParticipantOfTrainings", obj.PageUrl);

    }
}
