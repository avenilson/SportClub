using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Coach;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.Coach
{
    [TestClass]
    public class CoachTests: SealedClassTests<SportClub.Domain.Coach.Coach, Entity<CoachData>> { }
}
