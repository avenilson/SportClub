using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Common;

namespace SportClub.Tests.Data.CoachOfTraining
{
    [TestClass]
    public class CoachOfTrainingDataTests : SealedClassTests<CoachOfTrainingData, NamedEntityData>
    {
        [TestMethod]
        public void TrainingIdTest() => IsNullableProperty(() => obj.TrainingId, x => obj.TrainingId = x);

        [TestMethod]
        public void CoachIdTest() => IsNullableProperty(() => obj.CoachId, x => obj.CoachId = x);
    }
}
