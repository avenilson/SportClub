using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Domain.Coach;
using SportClub.Facade.Coach;
using SportClub.Pages;
using SportClub.Pages.Coach;

namespace SportClub.Tests.Pages.Coach
{
    [TestClass]
    public class CoachPageTests : AbstractClassTests
        <CoachesPage, CommonPage<ICoachesRepository, SportClub.Domain.Coach.Coach, CoachView, CoachData>>
    {
        private class TestClass : CoachesPage
        {
            internal TestClass(ICoachesRepository r) : base(r)
            {
            }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Coach.Coach, CoachData>,
            ICoachesRepository { } 

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
        public void PageUrlTest() => Assert.AreEqual("/Coach/Coaches", obj.PageUrl);

    }
}
