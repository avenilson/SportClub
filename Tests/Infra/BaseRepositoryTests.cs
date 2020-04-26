using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{

    [TestClass]
    public class BaseRepositoryTests : AbstractClassTests<BaseRepository<SportClub.Domain.Training.Training, TrainingData>, object>
    {
        private TrainingData data;

        private class TestClass : BaseRepository<SportClub.Domain.Training.Training, TrainingData>
        {
            public TestClass(DbContext c, DbSet<TrainingData> s) : base(c, s) { }

            protected override SportClub.Domain.Training.Training ToDomainObject(TrainingData d) => new SportClub.Domain.Training.Training(d);

            protected override async Task<TrainingData> GetData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }
            protected override string GetId(SportClub.Domain.Training.Training entity) => entity?.Data?.Id;

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new SportClubDbContext(options);
            obj = new TestClass(c, c.Trainings);
            data = GetRandom.Object<TrainingData>();
        }

        [TestMethod]
        public void GetTest()
        {
            var count = GetRandom.UInt8(15, 30);
            var countBefore = obj.Get().GetAwaiter().GetResult().Count;
            for (var i = 0; i < count; i++)
            {
                data = GetRandom.Object<TrainingData>();
                AddTest();
            }
            Assert.AreEqual(count + countBefore, obj.Get().GetAwaiter().GetResult().Count);
        }

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
            obj.Delete(data.Id).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        [TestMethod]
        public void AddTest()
        {
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(new SportClub.Domain.Training.Training(data)).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var newData = GetRandom.Object<TrainingData>();
            newData.Id = data.Id;
            obj.Update(new SportClub.Domain.Training.Training(newData)).GetAwaiter();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(newData, expected.Data);
        }
    }
}
