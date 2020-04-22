using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DropDownNavigationMenuForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DropDownNavigationMenuForHtmlExtension);

        [TestMethod]
        public void DropDownNavigationMenuForTest()
        {
            Assert.Inconclusive();
        }
    }
}