using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests: BaseTests
    {
        private string s;

      [TestInitialize] public virtual void TestInitialize() {
          type = typeof(TableRowForHtmlExtension);
          s = GetRandom.String();
      }

        [TestMethod]
        public void TableRowForTest()
        {
            //var obj = new HtmlHelperMock<CoachView>().TableRowFor(
            //GetRandom.Bool(),
            //new Uri(GetRandom.String(), UriKind.Relative),

            //GetRandom.String(),
            //new HtmlContentMock(GetRandom.String()),
            //new HtmlContentMock(GetRandom.String()));

            //Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        [TestMethod]
        public void TableRowWithSelectForTest()
        {
            //var obj = new HtmlHelperMock<CoachView>().TableRowWithSelectFor(
            //    GetRandom.Bool(),
            //    new Uri(GetRandom.String(), UriKind.Relative),

            //    GetRandom.String(),
            //    new HtmlContentMock(GetRandom.String()),
            //    new HtmlContentMock(GetRandom.String()));

            //Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}