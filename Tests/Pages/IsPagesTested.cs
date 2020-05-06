using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Pages
{
    [TestClass]
    public class IsPagesTested : AssemblyTests
    {
        private new const string assembly = "SportClub.Pages";

        protected override string Namespace(string name)
        {
            return $"{assembly}.{name}"; 
        }

        [TestMethod]
        public void IsExtensionsTested()
        {
            IsAllTested(assembly, Namespace("Extensions")); 
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
            IsAllTested(base.Namespace("Pages")); 
        }
    }
}
