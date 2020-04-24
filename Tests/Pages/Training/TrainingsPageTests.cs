using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;
using SportClub.Pages.Training;

namespace SportClub.Tests.Pages.Training
{
    [TestClass]
    public class TrainingsPageTests : AbstractClassTests
        <TrainingsPage, CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>>
    {
        private class TestClass : TrainingsPage
        {
            internal TestClass(ITrainingsRepository r) : base(r)
            {
            }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository { } 

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<TrainingView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Trainings", obj.PageTitle);

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/Training/Trainings", obj.PageUrl);

    }


}
