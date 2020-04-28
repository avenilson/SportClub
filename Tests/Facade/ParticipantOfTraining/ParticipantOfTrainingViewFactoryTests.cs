using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Facade.ParticipantOfTraining;

namespace SportClub.Tests.Facade.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(ParticipantOfTrainingViewFactory);
        }
        [TestMethod]
        public void CreateTest()
        {
        }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<ParticipantOfTrainingView>();
            var data = ParticipantOfTrainingViewFactory.Create(view).Data;

            TestArePropertyValuesEqual(view, data);
        }
        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<ParticipantOfTrainingData>();
            var view = ParticipantOfTrainingViewFactory.Create(new SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }

    }
}