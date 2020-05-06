using System;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Facade.Coach;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class HypertextLinkForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(HypertextLinkForHtmlExtension);

        [TestMethod]
        public void HypertextLinkForTest()
        {
            //var s = GetRandom.String();
            //var items = new[] {new SportClub.Pages.Extensions.Link("AA", new Uri("AAA", UriKind.Relative)), new SportClub.Pages.Extensions.Link("BB", new Uri("BBB", UriKind.Relative)) };
            //var obj = new HtmlHelperMock<CoachView>().HypertextLinkFor(s, items);
            //Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}