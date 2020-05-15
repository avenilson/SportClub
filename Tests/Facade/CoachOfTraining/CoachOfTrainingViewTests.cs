using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.CoachOfTraining;
using SportClub.Facade.Common;

namespace SportClub.Tests.Facade.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingViewTests : SealedClassTests<CoachOfTrainingView, UniqueEntityView>
    {
        [TestMethod]
        public void TrainingIdTest() => IsNullableProperty(() => obj.TrainingId, x => obj.TrainingId = x);

        [TestMethod]
        public void CoachIdTest() => IsNullableProperty(() => obj.CoachId, x => obj.CoachId = x);
        
        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.CoachId}.{obj.TrainingId}";
            Assert.AreEqual(expected, actual);
        }
    }
}