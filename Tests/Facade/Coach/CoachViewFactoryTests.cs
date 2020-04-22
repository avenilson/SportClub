using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Facade.Coach;

namespace SportClub.Tests.Facade.Coach
{
    [TestClass]
    public class CoachViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(CoachViewFactory);
        }
        [TestMethod]
        public void CreateTest()
        {
        }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<CoachView>();
            var data = CoachViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }
        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<CoachData>();
            var view = CoachViewFactory.Create(new SportClub.Domain.Coach.Coach(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
