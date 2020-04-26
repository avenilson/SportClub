using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Facade
{
    [TestClass]
    public class IsFacadeTested : AssemblyTests
    {
        private const string Assembly = "SportClub.Facade";
        protected override string Namespace(string name) { return $"{Assembly}.{name}"; }

        [TestMethod]
        public void IsCoachTested()
        {
            IsAllTested(Assembly, Namespace("Coach"));
        }
        [TestMethod]
        public void IsCoachOfTrainingTested()
        {
            IsAllTested(Assembly, Namespace("CoachOfTraining"));
        }
        [TestMethod]
        public void IsCommonTested()
        {
            IsAllTested(Assembly, Namespace("Common"));
        }
        [TestMethod]
        public void IsParticipantTested()
        {
            IsAllTested(Assembly, Namespace("Participant"));
        }
        [TestMethod]
        public void IsParticipantOfTrainingTested()
        {
            IsAllTested(Assembly, Namespace("ParticipantOfTraining"));
        }
        [TestMethod]
        public void IsTrainingTested()
        {
            IsAllTested(Assembly, Namespace("Training"));
        }
        [TestMethod]
        public void IsTrainingTypeTested()
        {
            IsAllTested(Assembly, Namespace("TrainingType"));
        }
        [TestMethod] public void IsTested() { IsAllTested(base.Namespace("Facade")); }

    }
}