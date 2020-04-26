using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Training;
using SportClub.Infra;
using SportClub.Infra.Training;

namespace SportClub.Tests.Infra.Training
{

    [TestClass]
    public class TrainingsRepositoryTests : RepositoryTests<TrainingsRepository, SportClub.Domain.Training.Training, TrainingData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext)db).Trainings;
            obj = new TrainingsRepository((SportClubDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<SportClub.Domain.Training.Training, TrainingData>);

        protected override string GetId(TrainingData d) => d.Id;

        protected override SportClub.Domain.Training.Training GetObject(TrainingData d) => new SportClub.Domain.Training.Training(d);

        protected override void SetId(TrainingData d, string id) => d.Id = id;
    }
}
