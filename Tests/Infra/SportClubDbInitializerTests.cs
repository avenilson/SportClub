using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Infra;

namespace SportClub.Tests.Infra
{
    [TestClass]
    public class SportClubDbInitializerTests : BaseTests
    {
        private SportClubDbContext db;
        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(SportClubDbInitializer);
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            SportClubDbInitializer.Initialize(db);
        }
        [TestMethod] public void InitializeTest() { }
        [TestMethod]
        public void MeasuresTest() => Assert.AreEqual(12, getCount(db.Measures));

        private int getCount<T>(DbSet<T> dbSet) where T : PeriodData, new()
        {
            return dbSet.CountAsync().GetAwaiter().GetResult();
        }

        [TestMethod]
        public void UnitsTest() => Assert.AreEqual(125, getCount(db.Units));
        [TestMethod]
        public void MeasureTermsTest() => Assert.AreEqual(2, getCount(db.MeasureTerms));
        [TestMethod]
        public void UnitTermsTest() => Assert.AreEqual(39, getCount(db.UnitTerms));
        [TestMethod]
        public void UnitFactorsTest() => Assert.AreEqual(90, getCount(db.UnitFactors));
        [TestMethod]
        public void SystemsOfUnitsTest() => Assert.AreEqual(2, getCount(db.SystemsOfUnits));
    }
}
