using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Coach;
using SportClub.Infra;
using SportClub.Infra.Coach;

namespace SportClub.Tests.Infra.Coach
{
    [TestClass]
    public class CoachesRepositoryTests : RepositoryTests<CoachesRepository, SportClub.Domain.Coach.Coach, CoachData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext)db).Coaches;
            obj = new CoachesRepository((SportClubDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<SportClub.Domain.Coach.Coach, CoachData>);

        protected override string GetId(CoachData d) => d.Id;

        protected override SportClub.Domain.Coach.Coach GetObject(CoachData d) => new SportClub.Domain.Coach.Coach(d);

        protected override void SetId(CoachData d, string id) => d.Id = id;
    }
}
