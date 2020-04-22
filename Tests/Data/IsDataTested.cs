using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Data
{
    [TestClass]
    public class IsDataTested : AssemblyTests
    {
        private const string assembly = "Abc.Data";

        protected override string Namespace(string name)
        {
            return $"{assembly}.{name}";
        }

        [TestMethod]
        public void IsCoachTested()
        {
            isAllTested(assembly, Namespace("Coach"));
        }
        [TestMethod]
        public void IsCoachOfTrainingTested()
        {
            isAllTested(assembly, Namespace("CoachOfTraining"));
        }
        [TestMethod]
        public void IsCommonTested()
        {
            isAllTested(assembly, Namespace("Common"));
        }
        [TestMethod]
        public void IsParticipantTested()
        {
            isAllTested(assembly, Namespace("Participant"));
        }
        [TestMethod]
        public void IsParticipantOfTrainingTested()
        {
            isAllTested(assembly, Namespace("ParticipantOfTraining"));
        }
        [TestMethod]
        public void IsTrainingTested()
        {
            isAllTested(assembly, Namespace("Training"));
        }
        [TestMethod]
        public void IsTrainingTypeTested()
        {
            isAllTested(assembly, Namespace("TrainingType"));
        }
        [TestMethod]
        public void IsTested()
        {
            isAllTested(base.Namespace("Data"));
        }
    }
}
