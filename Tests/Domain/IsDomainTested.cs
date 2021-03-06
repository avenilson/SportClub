﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Domain
{
    [TestClass]
    public class IsDomainTested : AssemblyTests
    {
        private new const string assembly = "SportClub.Domain";

        protected override string Namespace(string name) => $"{assembly}.{name}";

        [TestMethod]
        public void IsCommonTested() => IsAllTested(assembly, Namespace("Common"));

        [TestMethod]
        public void IsCoachTested() => IsAllTested(assembly, Namespace("Coach"));

        [TestMethod]
        public void IsCoachOfTrainingTested() => IsAllTested(assembly, Namespace("CoachOfTraining"));

        [TestMethod]
        public void IsParticipantTested() => IsAllTested(assembly, Namespace("Participant"));

        [TestMethod]
        public void IsParticipantOfTrainingTested() => IsAllTested(assembly, Namespace("ParticipantOfTraining"));

        [TestMethod]
        public void IsTrainingTested() => IsAllTested(assembly, Namespace("Training"));

        [TestMethod]
        public void IsTrainingTypeTested() => IsAllTested(assembly, Namespace("TrainingType"));

        [TestMethod]
        public void IsTested() => IsAllTested(base.Namespace("Domain"));
    }
}
