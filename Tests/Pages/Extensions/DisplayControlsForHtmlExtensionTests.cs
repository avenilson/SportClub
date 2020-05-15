using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Coach;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DisplayControlsForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(DisplayControlsForHtmlExtension);

        [TestMethod] 
        public void DisplayControlsForTest()
        {
            var obj = new HtmlHelperMock<CoachView>().DisplayControlsFor(x => x.Id); 
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}
