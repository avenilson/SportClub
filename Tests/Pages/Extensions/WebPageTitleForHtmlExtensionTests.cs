using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            Assert.Inconclusive();
        }
    }
}