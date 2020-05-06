using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Common;
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
        public void TrainingTypesTest() => Assert.AreEqual(0, getCount(db.TrainingTypes)); //expected peab olema tglt 5

        private int getCount<T>(DbSet<T> dbSet) where T : NamedEntityData, new()
        {
            return dbSet.CountAsync().GetAwaiter().GetResult();
        }
    }
}
