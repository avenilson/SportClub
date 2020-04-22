using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Training;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.Training
{
    [TestClass] public class UnitTermTests: SealedClassTests<SportClub.Domain.Training.Training, Entity<TrainingData>> { }
}
