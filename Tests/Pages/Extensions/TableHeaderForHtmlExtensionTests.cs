using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Facade.Coach;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class TableHeaderForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(TableHeaderForHtmlExtension);

        [TestMethod]
        public void TableHeaderForTest()
        {
            var obj = new HtmlHelperMock<CoachView>().TableHeaderFor(GetRandom.String());
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}