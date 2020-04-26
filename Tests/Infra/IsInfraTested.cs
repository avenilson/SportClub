using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Infra
{
    [TestClass]
    public class IsInfraTested: AssemblyTests
    {
        private const string assembly = "SportClub.Infra";

        protected override string Namespace(string name)
        {
            return $"{assembly}.{name}";
        }

        [TestMethod]
        public void IsCoachTested()
        {
            IsAllTested(assembly, Namespace("Coach"));
        }
        [TestMethod]
        public void IsCoachOfTrainingTested()
        {
            IsAllTested(assembly, Namespace("CoachOfTraining"));
        }
        [TestMethod]
        public void IsParticipantTested()
        {
            IsAllTested(assembly, Namespace("Participant"));
        }
        [TestMethod]
        public void IsParticipantOfTrainingTested()
        {
            IsAllTested(assembly, Namespace("ParticipantOfTraining"));
        }
        [TestMethod]
        public void IsTrainingTested()
        {
            IsAllTested(assembly, Namespace("Training"));
        }
        [TestMethod]
        public void IsTrainingTypeTested()
        {
            IsAllTested(assembly, Namespace("TrainingType"));
        }
        [TestMethod]
        public void IsTested()
        {
            IsAllTested(base.Namespace("Infra"));
        }
    }
}
