using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Common;
using SportClub.Data.ParticipantOfTraining;

namespace SportClub.Tests.Data.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingDataTests : SealedClassTests<ParticipantOfTrainingData, NamedEntityData>
    {
        [TestMethod]
        public void TrainingIdTest() => IsNullableProperty(() => obj.TrainingId, x => obj.TrainingId = x);

        [TestMethod]
        public void ParticipantIdTest() => IsNullableProperty(() => obj.ParticipantId, x => obj.ParticipantId = x);
    }
}
