using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Facade.Training;
using SportClub.Pages;
using SportClub.Pages.Training;
using SportClub.Tests.Aids;

namespace SportClub.Tests.Pages.Training
{
    [TestClass]
    public class TrainingsPageTests : AbstractClassTests
        <TrainingsPage, CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>>
    {
        private class TestClass : TrainingsPage
        {
            internal TestClass(ITrainingsRepository r, ITrainingTypesRepository t) : base(r, t) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository { } 
        private class TermRepository :  BaseTestRepositoryForUniqueEntity<SportClub.Domain.TrainingType.TrainingType, TrainingTypeData>,
            ITrainingTypesRepository { } 
       
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
            var r = new TestRepository();
            var t = new TermRepository();
            obj = new TestClass(r, t); //annan repository katte
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
        [TestMethod] public void TypesTest()
        {
            //
        }
    }


}
