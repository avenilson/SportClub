using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{
    [TestClass]
    public class SortedRepositoryTests : AbstractClassTests<SortedRepository<SportClub.Domain.Training.Training, TrainingData>, BaseRepository<SportClub.Domain.Training.Training, TrainingData>>
    {
        private class TestClass : SortedRepository<SportClub.Domain.Training.Training, TrainingData>
        {
            public TestClass(DbContext c, DbSet<TrainingData> s) : base(c, s) { }

            protected override SportClub.Domain.Training.Training ToDomainObject(TrainingData d) => new SportClub.Domain.Training.Training(d);

            protected override async Task<TrainingData> GetData(string id)
            {
                await Task.CompletedTask;
                return new TrainingData();
            }

            protected override string GetId(SportClub.Domain.Training.Training entity) => entity?.Data?.Id;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<SportClubDbContext>().UseInMemoryDatabase("TestDb").Options;
            var c = new SportClubDbContext(options);
            obj = new TestClass(c, c.Trainings);
        }

        [TestMethod]
        public void SortOrderTest()
        {
            IsNullableProperty(() => obj.SortOrder, x => obj.SortOrder = x);
        }
        [TestMethod]
        public void DescendingStringTest()
        {
            var propertyName = GetMember.Name<TestClass>(x => x.DescendingString);
            IsReadOnlyProperty(obj, propertyName, "_desc");
        }
        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var o = obj.CreateSqlQuery();
            Assert.IsNotNull(o);
        }
        [TestMethod]
        public void SetSortingTest()
        {
            void Test(IQueryable<TrainingData> d, string sortOrder)
            {
                obj.SortOrder = sortOrder + obj.DescendingString;
                var set = obj.AddSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                var str = set.Expression.ToString();
                Assert.IsTrue(str
                    .Contains($"SportClub.Data.Training.TrainingData]).OrderByDescending(x => Convert(x.{sortOrder}, Object))"));
                obj.SortOrder = sortOrder;
                set = obj.AddSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                str = set.Expression.ToString();
                Assert.IsTrue(str.Contains($"SportClub.Data.Training.TrainingData]).OrderBy(x => Convert(x.{sortOrder}, Object))"));
            }
            Assert.IsNull(obj.AddSorting(null));
            IQueryable<TrainingData> data = obj.dbSet;
            obj.SortOrder = null;
            Assert.AreEqual(data, obj.AddSorting(data));
            Test(data, GetMember.Name<TrainingData>(x => x.Id));
            Test(data, GetMember.Name<TrainingData>(x => x.Duration));
            Test(data, GetMember.Name<TrainingData>(x => x.Name));
            Test(data, GetMember.Name<TrainingData>(x => x.Definition));
            Test(data, GetMember.Name<TrainingData>(x => x.ParticipantsCount));
        }
        [TestMethod]
        public void CreateExpressionTest()
        {
            string s;
            TestCreateExpression(GetMember.Name<TrainingData>(x => x.Duration));
            TestCreateExpression(GetMember.Name<TrainingData>(x => x.ParticipantsCount));
            TestCreateExpression(GetMember.Name<TrainingData>(x => x.Id));
            TestCreateExpression(GetMember.Name<TrainingData>(x => x.Name));
            TestCreateExpression(GetMember.Name<TrainingData>(x => x.Definition));
            TestCreateExpression(s = GetMember.Name<TrainingData>(x => x.Duration), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<TrainingData>(x => x.ParticipantsCount), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<TrainingData>(x => x.Id), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<TrainingData>(x => x.Name), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<TrainingData>(x => x.Definition), s + obj.DescendingString);
            TestNullExpression(GetRandom.String());
            TestNullExpression(string.Empty);
            TestNullExpression(null);
        }

        private void TestNullExpression(string name)
        {
            obj.SortOrder = name;
            var lambda = obj.CreateExpression();
            Assert.IsNull(lambda);
        }

        private void TestCreateExpression(string expected, string name = null)
        {
            name ??= expected;
            obj.SortOrder = name;
            var lambda = obj.CreateExpression();
            Assert.IsNotNull(lambda);
            Assert.IsInstanceOfType(lambda, typeof(Expression<Func<TrainingData, object>>));
            Assert.IsTrue(lambda.ToString().Contains(expected));
        }

        //[TestMethod]
        //public void LambdaExpressionTest()
        //{
        //    var name = GetMember.Name<TrainingData>(x => x.ValidFrom);
        //    var property = typeof(TrainingData).GetProperty(name);
        //    var lambda = obj.LambdaExpression(property);
        //    Assert.IsNotNull(lambda);
        //    Assert.IsInstanceOfType(lambda, typeof(Expression<Func<TrainingData, object>>));
        //    Assert.IsTrue(lambda.ToString().Contains(name));
        //}

        [TestMethod]
        public void FindPropertyTest()
        {
            string s;
            void Test(PropertyInfo expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.FindProperty());
            }
            Test(null, GetRandom.String());
            Test(null, null);
            Test(null, string.Empty);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Name)), s);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.ParticipantsCount)), s);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Definition)), s);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Duration)), s);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Id)), s);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Name)), s + obj.DescendingString);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.ParticipantsCount)), s + obj.DescendingString);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Definition)), s + obj.DescendingString);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Duration)), s + obj.DescendingString);
            Test(typeof(TrainingData).GetProperty(s = GetMember.Name<TrainingData>(x => x.Id)), s + obj.DescendingString);
        }
        [TestMethod]
        public void GetNameTest()
        {
            string s;
            void Test(string expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.GetName());
            }
            Test(s = GetRandom.String(), s);
            Test(s = GetRandom.String(), s + obj.DescendingString);
            Test(string.Empty, string.Empty);
            Test(string.Empty, null);
        }
        [TestMethod]
        public void SetOrderByTest()
        {
            void Test(IQueryable<TrainingData> d, Expression<Func<TrainingData, object>> e, string expected)
            {
                obj.SortOrder = GetRandom.String() + obj.DescendingString;
                var set = obj.AddOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString()
                    .Contains($"SportClub.Data.Training.TrainingData]).OrderByDescending({expected})"));
                obj.SortOrder = GetRandom.String();
                set = obj.AddOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString().Contains($"SportClub.Data.Training.TrainingData]).OrderBy({expected})"));
            }
            Assert.IsNull(obj.AddOrderBy(null, null));
            IQueryable<TrainingData> data = obj.dbSet;
            Assert.AreEqual(data, obj.AddOrderBy(data, null));
            Test(data, x => x.Id, "x => x.Id");
            Test(data, x => x.Duration, "x => x.Duration");
            Test(data, x => x.Name, "x => x.Name");
            Test(data, x => x.Definition, "x => x.Definition");
            Test(data, x => x.ParticipantsCount, "x => x.ParticipantsCount");
        }
        [TestMethod]
        public void IsDescendingTest()
        {
            void Test(string sortOrder, bool expected)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.IsDescending());
            }
            Test(GetRandom.String(), false);
            Test(GetRandom.String() + obj.DescendingString, true);
            Test(string.Empty, false);
            Test(null, false);
        }
    }
}
