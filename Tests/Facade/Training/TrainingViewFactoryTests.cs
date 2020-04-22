using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Facade.Training;

namespace SportClub.Tests.Facade.Training
{
    [TestClass]
    public class TrainingViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(TrainingViewFactory);
        }
        [TestMethod]
        public void CreateTest()
        {
        }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<TrainingView>();
            var data = TrainingViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }
        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<TrainingData>();
            var view = TrainingViewFactory.Create(new SportClub.Domain.Training.Training(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}