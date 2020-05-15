using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.TrainingType;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.TrainingType
{
    [TestClass] 
    public class TrainingTypeTests: SealedClassTests<SportClub.Domain.TrainingType.TrainingType, Entity<TrainingTypeData>> { }
}
