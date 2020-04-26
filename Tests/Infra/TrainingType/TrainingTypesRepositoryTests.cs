using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.TrainingType;
using SportClub.Infra;
using SportClub.Infra.TrainingType;

namespace SportClub.Tests.Infra.TrainingType
{
    [TestClass]
    public class TrainingTypesRepositoryTests : RepositoryTests<TrainingTypesRepository,
        SportClub.Domain.TrainingType.TrainingType, TrainingTypeData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext) db).TrainingTypes;
            obj = new TrainingTypesRepository((SportClubDbContext) db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() =>
            typeof(UniqueEntityRepository<SportClub.Domain.TrainingType.TrainingType, TrainingTypeData>);

        protected override string GetId(TrainingTypeData d) => d.Id;

        protected override SportClub.Domain.TrainingType.TrainingType GetObject(TrainingTypeData d) =>
            new SportClub.Domain.TrainingType.TrainingType(d);

        protected override void SetId(TrainingTypeData d, string id) => d.Id = id;
    }
}