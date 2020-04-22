using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.TrainingType;
using SportClub.Facade.TrainingType;

namespace SportClub.Tests.Facade.TrainingType
{
    [TestClass]
    public class TrainingTypeViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(TrainingTypeViewFactory);
        }
        [TestMethod]
        public void CreateTest()
        {
        }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<TrainingTypeView>();
            var data = TrainingTypeViewFactory.Create(view).Data;

            TestArePropertyValuesEqual(view, data);
        }
        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<TrainingTypeData>();
            var view = TrainingTypeViewFactory.Create(new SportClub.Domain.TrainingType.TrainingType(data));
            TestArePropertyValuesEqual(view, data);
        }

    }
}