using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.CoachOfTraining;
using SportClub.Pages;
using SportClub.Pages.CoachOfTraining;

namespace SportClub.Tests.Pages.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingsPageTests : AbstractClassTests
        <CoachOfTrainingsPage, CommonPage<ICoachOfTrainingsRepository, SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>>
    {
        private class TestClass : CoachOfTrainingsPage
        {
            internal TestClass(ICoachOfTrainingsRepository r) : base(r) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>,
            ICoachOfTrainingsRepository { }

        private class TermRepository : BaseTestRepositoryForNamedEntity<SportClub.Domain.Coach.Coach, CoachData>,
            ICoachesRepository
        {
            protected override bool isThis(SportClub.Domain.Coach.Coach entity, string id)
            {
                return true;
            }

            protected override string getId(SportClub.Domain.Coach.Coach entity)
            {
                return string.Empty;
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
            var r = new TestRepository();
            var t = new TermRepository();
            obj = new TestClass(r); //annan repository katte
        }

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
        public void GetPageUrlTest() => Assert.AreEqual("/CoachOfTraining/CoachOfTrainings", obj.PageUrl);

        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<CoachOfTrainingView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<CoachOfTrainingData>();
            var view = obj.ToView(new SportClub.Domain.CoachOfTraining.CoachOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
