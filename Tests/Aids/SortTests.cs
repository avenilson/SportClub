using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;

namespace SportClub.Tests.Aids {

    [TestClass] public class SortTests : BaseTests {

        [TestInitialize] public void TestInitialize() => type = typeof(Sort);

        [TestMethod]
        public void UpwardsTest()
        {
            var random = new Random();
            int min = random.Next(); 
            int max = random.Next();
            TestArePropertyValuesEqual(min, max);
        }
    }
}