using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Common;
using SportClub.Data.Training;

namespace SportClub.Tests.Data.Training
{
    [TestClass]
    public class TrainingDataTests : SealedClassTests<TrainingData, NamedEntityData>
    {
        [TestMethod]
        public void DefinitionTest()
        {
            IsNullableProperty(() => obj.Definition, x => obj.Definition = x);
        }
        [TestMethod]
        public void DurationTest()
        {
            IsNullableProperty(() => obj.Duration, x => obj.Duration = x);
        }

        [TestMethod]
        public void ParticipantsTest()
        {
            IsNullableProperty(() => obj.ParticipantsCount, x => obj.ParticipantsCount = x);
        }
    }
}
