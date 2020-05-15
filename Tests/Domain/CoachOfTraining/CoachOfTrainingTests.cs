using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.CoachOfTraining
{
    [TestClass] 
    public class CoachOfTrainingTests: SealedClassTests<SportClub.Domain.CoachOfTraining.CoachOfTraining, Entity<CoachOfTrainingData>> { }
}
