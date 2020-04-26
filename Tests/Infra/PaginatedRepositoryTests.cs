using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{
    [TestClass]
    public class PaginatedRepositoryTests : AbstractClassTests<PaginatedRepository<SportClub.Domain.Training.Training, TrainingData>,
        FilteredRepository<SportClub.Domain.Training.Training, TrainingData>>
    {
        private class TestClass : PaginatedRepository<SportClub.Domain.Training.Training, TrainingData>
        {
            public TestClass(DbContext c, DbSet<TrainingData> s) : base(c, s) { }

            protected override SportClub.Domain.Training.Training ToDomainObject(TrainingData d) => new SportClub.Domain.Training.Training(d);

            protected override async Task<TrainingData> GetData(string id) => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

            protected override string GetId(SportClub.Domain.Training.Training entity) => entity?.Data?.Id;

        }

        private byte count;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new SportClubDbContext(options);
            obj = new TestClass(c, c.Trainings);
            count = GetRandom.UInt8(20, 40);
            foreach (var p in c.Trainings)
                c.Entry(p).State = EntityState.Deleted;
            AddItems();
        }
        [TestMethod]
        public void PageIndexTest()
        {
            IsProperty(() => obj.PageIndex, x => obj.PageIndex = x);
        }

        [TestMethod]
        public void TotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.TotalPages;
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void HasNextPageTest()
        {
            void TestNextPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasNextPage;
                Assert.AreEqual(expected, actual);
            }
            TestNextPage(0, true);
            TestNextPage(1, true);
            TestNextPage(GetRandom.Int32(2, obj.TotalPages - 1), true);
            TestNextPage(obj.TotalPages, false);
        }

        [TestMethod]
        public void HasPreviousPageTest()
        {
            void TestPreviousPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasPreviousPage;
                Assert.AreEqual(expected, actual);
            }
            TestPreviousPage(0, false);
            TestPreviousPage(1, false);
            TestPreviousPage(2, true);
            TestPreviousPage(GetRandom.Int32(2, obj.TotalPages), true);
            TestPreviousPage(obj.TotalPages, true);
        }

        [TestMethod]
        public void PageSizeTest()
        {
            Assert.AreEqual(5, obj.PageSize);
            IsProperty(() => obj.PageSize, x => obj.PageSize = x);
        }

        [TestMethod]
        public void GetTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.GetTotalPages(obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void CountTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.CountTotalPages(count, obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void GetItemsCountTest()
        {
            var itemsCount = obj.GetItemsCount();
            Assert.AreEqual(count, itemsCount);
        }

        private void AddItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(new SportClub.Domain.Training.Training(GetRandom.Object<TrainingData>())).GetAwaiter();
        }

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var o = obj.CreateSqlQuery();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void AddSkipAndTakeTest()
        {
            var sql = obj.CreateSqlQuery();
            var o = obj.AddSkipAndTake(sql);
            Assert.IsNotNull(o);
        }
    }
}

