using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.CoachOfTraining;
using SportClub.Facade.CoachOfTraining;

namespace SportClub.Tests.Facade.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(CoachOfTrainingViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<CoachOfTrainingView>();
            var data = CoachOfTrainingViewFactory.Create(view).Data;

            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<CoachOfTrainingData>();
            var view = CoachOfTrainingViewFactory.Create(new SportClub.Domain.CoachOfTraining.CoachOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}