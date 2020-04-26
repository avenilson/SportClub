using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;
using SportClub.Pages.Training;
using SportClub.Tests.Pages.Participant;

namespace SportClub.Tests.Pages.Training
{
    [TestClass]
    public class TrainingsPageTests : AbstractClassTests
        <TrainingsPage, CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>>
    {
        private class TestClass : TrainingsPage
        {
            internal TestClass(ITrainingsRepository r) : base(r) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository { } 
       
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
            var r = new TrainingsPageTests.TestRepository();
            obj = new TrainingsPageTests.TestClass(r); //annan repository katte
        }

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
        public void GetPageUrlTest() => Assert.AreEqual("/Training/Trainings", obj.PageUrl);
        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<TrainingView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<TrainingData>();
            var view = obj.ToView(new SportClub.Domain.Training.Training(data));
            TestArePropertyValuesEqual(view, data);
        }

    }


}
