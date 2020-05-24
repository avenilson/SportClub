using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Domain.Training;
using SportClub.Facade.CoachOfTraining;
using SportClub.Pages;
using SportClub.Pages.CoachOfTraining;

namespace SportClub.Tests.Pages.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingsPageTests : AbstractClassTests
        <CoachOfTrainingsPage, CommonPage<ICoachOfTrainingsRepository, SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>>
    {
        private class TrainRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository { }

        private class TestClass : CoachOfTrainingsPage
        {
            internal TestClass(ICoachOfTrainingsRepository r, ICoachesRepository c, ITrainingsRepository t) : base(r, c, t) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>,
            ICoachOfTrainingsRepository { }

        private class TermRepository : BaseTestRepositoryForNamedEntity<SportClub.Domain.Coach.Coach, CoachData>,
            ICoachesRepository
        {
            protected override bool IsThis(SportClub.Domain.Coach.Coach entity, string id) => true;

            protected override string GetId(SportClub.Domain.Coach.Coach entity) => string.Empty;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); 
            var r = new TestRepository();
            var c = new TermRepository();
            var t = new TrainRepository();
            obj = new TestClass(r, c, t); 
        }

        public static string Id(string head, string tail) => $"{head}.{tail}";

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Coach Of Trainings", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/CoachOfTraining/CoachOfTrainings", obj.PageUrl);

        [TestMethod] 
        public void ToObjectTest()
        {
            var view = GetRandom.Object<CoachOfTrainingView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod] 
        public void ToViewTest()
        {
            var data = GetRandom.Object<CoachOfTrainingData>();
            var view = obj.ToView(new SportClub.Domain.CoachOfTraining.CoachOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void GetCoachNameTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void GetTrainingNameTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void CoachesTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void TrainingIdTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());

        [TestMethod]
        public void IdsTest()
        {
            var item = GetRandom.Object<CoachOfTrainingView>();
            obj.Item = item;
            string a = Id(item.CoachId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
    }
}
