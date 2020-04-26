using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{

    [TestClass]
    public class FilteredRepositoryTests : AbstractClassTests<FilteredRepository<SportClub.Domain.Training.Training, TrainingData>,
        SortedRepository<SportClub.Domain.Training.Training, TrainingData>>
    {
        private class testClass : FilteredRepository<SportClub.Domain.Training.Training, TrainingData>
        {

            public testClass(DbContext c, DbSet<TrainingData> s) : base(c, s) { }

            protected override SportClub.Domain.Training.Training ToDomainObject(TrainingData d) => new SportClub.Domain.Training.Training(d);

            protected override async Task<TrainingData> getData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }

            protected override string getId(SportClub.Domain.Training.Training entity) => entity?.Data?.Id;

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new SportClubDbContext(options);
            obj = new testClass(c, c.Trainings);
        }

        [TestMethod]
        public void SearchStringTest()
            => IsNullableProperty(() => obj.SearchString, x => obj.SearchString = x);

        [TestMethod]
        public void FixedFilterTest()
            => IsNullableProperty(() => obj.FixedFilter, x => obj.FixedFilter = x);

        [TestMethod]
        public void FixedValueTest()
            => IsNullableProperty(() => obj.FixedValue, x => obj.FixedValue = x);

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var sql = obj.createSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void AddFixedFilteringTest()
        {
            var sql = obj.createSqlQuery();
            var fixedFilter = GetMember.Name<TrainingData>(x => x.Definition);
            obj.FixedFilter = fixedFilter;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var sqlNew = obj.AddFixedFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void CreateFixedWhereExpressionTest()
        {
            var properties = typeof(TrainingData).GetProperties();
            var idx = GetRandom.Int32(0, properties.Length);
            var p = properties[idx];
            obj.FixedFilter = p.Name;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var e = obj.CreateFixedWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            var expected = p.Name;
            if (p.PropertyType != typeof(string))
                expected += ".ToString()";
            expected += $" == \"{fixedValue}\"";
            Assert.IsTrue(s.Contains(expected));
        }

        [TestMethod]
        public void CreateFixedWhereExpressionOnFixedFilterNullTest()
        {
            Assert.IsNull(obj.CreateFixedWhereExpression());
            obj.FixedValue = GetRandom.String();
            obj.FixedFilter = GetRandom.String();
            Assert.IsNull(obj.CreateFixedWhereExpression());
        }

        //[TestMethod]
        //public void AddFilteringTest()
        //{
        //    var sql = obj.createSqlQuery();
        //    var searchString = GetRandom.String();
        //    obj.SearchString = searchString;
        //    var sqlNew = obj.AddFiltering(sql);
        //    Assert.IsNotNull(sqlNew);
        //}

        [TestMethod]
        public void CreateWhereExpressionTest()
        {
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var e = obj.CreateWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            foreach (var p in typeof(TrainingData).GetProperties())
            {
                var expected = p.Name;
                if (p.PropertyType != typeof(string))
                    expected += ".ToString()";
                expected += $".Contains(\"{searchString}\")";
                Assert.IsTrue(s.Contains(expected));
            }
        }
        [TestMethod]
        public void CreateWhereExpressionWithNullSearchStringTest()
        {
            obj.SearchString = null;
            var e = obj.CreateWhereExpression();
            Assert.IsNull(e);
        }

    }

}