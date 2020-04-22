using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Common;
using SportClub.Facade.ParticipantOfTraining;

namespace SportClub.Tests.Facade.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingViewTests : SealedClassTests<ParticipantOfTrainingView, NamedView>
    {
        [TestMethod]
        public void TrainingIdTest() => IsNullableProperty(() => obj.TrainingId, x => obj.TrainingId = x);
        [TestMethod]
        public void ParticipantIdTest() => IsNullableProperty(() => obj.ParticipantId, x => obj.ParticipantId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.ParticipantId}.{obj.TrainingId}";
            Assert.AreEqual(expected, actual);
        }

    }
}