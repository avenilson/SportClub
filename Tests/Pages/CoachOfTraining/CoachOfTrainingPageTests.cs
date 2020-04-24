using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.CoachOfTraining;
using SportClub.Pages;
using SportClub.Pages.CoachOfTraining;

namespace SportClub.Tests.Pages.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingPageTests : AbstractClassTests
        <CoachOfTrainingsPage, CommonPage<ICoachOfTrainingsRepository, SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>>
    {
        private class TestClass : CoachOfTrainingsPage
        {
            internal TestClass(ICoachOfTrainingsRepository r) : base(r)
            {
            }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>,
            ICoachOfTrainingsRepository { } 

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Coach Of Trainings", obj.PageTitle);

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/CoachOfTraining/CoachOfTrainings", obj.PageUrl);

    }
}
