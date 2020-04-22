﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            isAllTested(Assembly, Namespace("Coach"));
        }
        [TestMethod]
        public void IsCoachOfTrainingTested()
        {
            isAllTested(Assembly, Namespace("CoachOfTraining"));
        }
        [TestMethod]
        public void IsCommonTested()
        {
            isAllTested(Assembly, Namespace("Common"));
        }
        [TestMethod]
        public void IsParticipantTested()
        {
            isAllTested(Assembly, Namespace("Participant"));
        }
        [TestMethod]
        public void IsParticipantOfTrainingTested()
        {
            isAllTested(Assembly, Namespace("ParticipantOfTraining"));
        }
        [TestMethod]
        public void IsTrainingTested()
        {
            isAllTested(Assembly, Namespace("Training"));
        }
        [TestMethod]
        public void IsTrainingTypeTested()
        {
            isAllTested(Assembly, Namespace("TrainingType"));
        }
        [TestMethod] public void IsTested() { isAllTested(base.Namespace("Facade")); }

    }
}