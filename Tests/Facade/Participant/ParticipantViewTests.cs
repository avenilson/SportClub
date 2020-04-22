using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.CoachOfTraining;
using SportClub.Facade.Common;
using SportClub.Facade.Participant;

namespace SportClub.Tests.Facade.Participant
{
    [TestClass]
    public class ParticipantViewTests : SealedClassTests<ParticipantView, NamedView>
    {
        [TestMethod]
        public void AgeTest() => IsProperty(() => obj.Age, x => obj.Age = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);

    }
}