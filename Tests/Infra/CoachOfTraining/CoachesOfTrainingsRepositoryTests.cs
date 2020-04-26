using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.CoachOfTraining;
using SportClub.Infra;
using SportClub.Infra.CoachOfTraining;

namespace SportClub.Tests.Infra.CoachOfTraining
{

    [TestClass]
    public class CoachesOfTrainingsRepositoryTests : RepositoryTests<CoachOfTrainingsRepository, SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext)db).CoachesOfTrainings;
            obj = new CoachOfTrainingsRepository((SportClubDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(PaginatedRepository<SportClub.Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingData>);

        protected override string GetId(CoachOfTrainingData d) => $"{d.CoachId}.{d.TrainingId}";

        protected override SportClub.Domain.CoachOfTraining.CoachOfTraining GetObject(CoachOfTrainingData d) => new SportClub.Domain.CoachOfTraining.CoachOfTraining(d);

        protected override void SetId(CoachOfTrainingData d, string id)
        {
            var coachId = GetString.Head(id);
            var trainingId = GetString.Tail(id);
            d.CoachId = coachId;
            d.TrainingId = trainingId;
        }
    }
}
