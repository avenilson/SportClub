using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class TableHeaderForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(TableHeaderForHtmlExtension);

        [TestMethod]
        public void TableHeaderForTest()
        {
            Assert.Inconclusive();
        }
    }
}