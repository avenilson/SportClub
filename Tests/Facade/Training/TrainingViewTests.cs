using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Common;
using SportClub.Facade.Training;

namespace SportClub.Tests.Facade.Training
{
    [TestClass]
    public class TrainingViewTests : SealedClassTests<TrainingView, NamedView>
    {
        [TestMethod]
        public void DurationTest() => IsProperty(() => obj.Duration, x => obj.Duration = x);

        [TestMethod]
        public void DefinitionTest() => IsNullableProperty(() => obj.Definition, x => obj.Definition = x);
        
        [TestMethod]
        public void MaxParticipantsTest() => IsProperty(() => obj.MaxParticipants, x => obj.MaxParticipants = x);

    }
}