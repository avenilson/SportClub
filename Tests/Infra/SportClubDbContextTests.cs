using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Data.TrainingType;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{
    [TestClass]
    public class SportClubDbContextTests : BaseClassTests<SportClubDbContext, DbContext>
    {
        private DbContextOptions<SportClubDbContext> options;
        private class TestClass : SportClubDbContext
        {
            public TestClass(DbContextOptions<SportClubDbContext> o) : base(o) { }
            public ModelBuilder RunOnModelCreating()
            {
                var set = new ConventionSet();
                var mb = new ModelBuilder(set);
                OnModelCreating(mb);
                return mb;
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            options = new DbContextOptionsBuilder<SportClubDbContext>().UseInMemoryDatabase("TestDb").Options;
            obj = new SportClubDbContext(options);
        }

        [TestMethod]
        public void InitializeTablesTest()
        {
            static void TestKey<T>(IMutableEntityType entity, params Expression<Func<T, object>>[] values)
            {
                var key = entity.FindPrimaryKey();

                if (values is null) Assert.IsNull(key);
                else
                    foreach (var v in values)
                    {
                        var name = GetMember.Name(v);
                        Assert.IsNotNull(key.Properties.FirstOrDefault(x => x.Name == name));
                    }
            }

            static void TestEntity<T>(ModelBuilder b, params Expression<Func<T, object>>[] values)
            {
                var name = typeof(T).FullName ?? string.Empty;
                var entity = b.Model.FindEntityType(name);
                Assert.IsNotNull(entity, name);
                TestKey(entity, values);
            }

            SportClubDbContext.InitializeTables(null);
            var o = new TestClass(options);
            var builder = o.RunOnModelCreating();
            SportClubDbContext.InitializeTables(builder);
            TestEntity<CoachData>(builder);
            TestEntity<CoachOfTrainingData>(builder, x => x.TrainingId, x => x.CoachId);
            TestEntity<ParticipantData>(builder);
            TestEntity<ParticipantOfTrainingData>(builder, x => x.TrainingId, x => x.ParticipantId);
            TestEntity<TrainingData>(builder);
            TestEntity<TrainingTypeData>(builder);
        }

        [TestMethod]
        public void CoachesTest() => IsNullableProperty(obj, nameof(obj.Coaches), typeof(DbSet<CoachData>));

        [TestMethod]
        public void CoachesOfTrainingsTest() => IsNullableProperty(obj, nameof(obj.CoachesOfTrainings), typeof(DbSet<CoachOfTrainingData>));

        [TestMethod]
        public void ParticipantsTest() => IsNullableProperty(obj, nameof(obj.Participants), typeof(DbSet<ParticipantData>));

        [TestMethod]
        public void ParticipantsOfTrainingsTest() => IsNullableProperty(obj, nameof(obj.ParticipantsOfTrainings), typeof(DbSet<ParticipantOfTrainingData>));

        [TestMethod]
        public void TrainingsTest() => IsNullableProperty(obj, nameof(obj.Trainings), typeof(DbSet<TrainingData>));

        [TestMethod]
        public void TrainingTypesTest() => IsNullableProperty(obj, nameof(obj.TrainingTypes), typeof(DbSet<TrainingTypeData>));
    }
}
