using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.CoachOfTraining;
using SportClub.Facade.Common;

namespace SportClub.Tests.Facade.CoachOfTraining
{
    public class CoachOfTrainingViewTests : SealedClassTests<CoachOfTrainingView, NamedView>
    {
        [TestMethod]
        public void TrainingIdTest() => IsNullableProperty(() => obj.TrainingId, x => obj.TrainingId = x);
        [TestMethod]
        public void CoachIdTest() => IsNullableProperty(() => obj.CoachId, x => obj.CoachId = x);
        
        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.CoachId}.{obj.TrainingId}";
            Assert.AreEqual(expected, actual);
        }

    }
}