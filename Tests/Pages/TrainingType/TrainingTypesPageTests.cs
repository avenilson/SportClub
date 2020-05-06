using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Domain.Training;
using SportClub.Domain.TrainingType;
using SportClub.Facade.TrainingType;
using SportClub.Pages;
using SportClub.Pages.TrainingType;

namespace SportClub.Tests.Pages.TrainingType
{
    [TestClass]
    public class TrainingTypesPageTests: AbstractClassTests
        <TrainingTypesPage, CommonPage<ITrainingTypesRepository, SportClub.Domain.TrainingType.TrainingType, TrainingTypeView, TrainingTypeData>>
    {
        public class TestClass : TrainingTypesPage
        {
            internal TestClass(ITrainingTypesRepository r, ITrainingsRepository n) : base(r, n) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.TrainingType.TrainingType, TrainingTypeData>,
            ITrainingTypesRepository { } 
        private class TermRepository : BaseTestRepositoryForNamedEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository
        {
            protected override bool IsThis(SportClub.Domain.Training.Training entity, string id)
            {
                return true;
            }

            protected override string GetId(SportClub.Domain.Training.Training entity)
            {
                return string.Empty;
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            var n = new TermRepository();
            obj = new TestClass(r, n);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<TrainingTypeView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Training Types", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/TrainingType/TrainingTypes", obj.PageUrl);
        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<TrainingTypeView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<TrainingTypeData>();
            var view = obj.ToView(new SportClub.Domain.TrainingType.TrainingType(data));
            TestArePropertyValuesEqual(view, data);
        }
        [TestMethod]
        public void GetNamesNameTest()
        {
            //
        }
        [TestMethod]
        public void GetPageSubTitleTest()
        {
            //
        }
        [TestMethod]
        public void NamesTest()
        {
            //
        }
    }
}
