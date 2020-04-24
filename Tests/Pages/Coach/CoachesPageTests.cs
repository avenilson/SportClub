using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.Coach;
using SportClub.Pages;
using SportClub.Pages.Coach;

namespace SportClub.Tests.Pages.Coach
{
    [TestClass]
    public class CoachesPageTests : AbstractClassTests
        <CoachesPage, CommonPage<ICoachesRepository, SportClub.Domain.Coach.Coach, CoachView, CoachData>>
    {
        private class TestClass : CoachesPage
        {
            internal TestClass(ICoachesRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Coach.Coach, CoachData>,
            ICoachesRepository { } 
        private class TermRepository :  BaseTestRepositoryForNamedEntity<SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>,
            ICoachOfTrainingsRepository {
            protected override bool isThis(SportClub.Domain.CoachOfTraining.CoachOfTraining entity, string id)
            {
                return true;
            }

            protected override string getId(SportClub.Domain.CoachOfTraining.CoachOfTraining entity)
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
            var item = GetRandom.Object<CoachView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Coaches", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Coach/Coaches", obj.PageUrl);
        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<CoachView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }
        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<CoachData>();
            var view = obj.ToView(new SportClub.Domain.Coach.Coach(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
