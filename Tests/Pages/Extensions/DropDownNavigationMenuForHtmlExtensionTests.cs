using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Coach;
using SportClub.Facade.TrainingType;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DropDownNavigationMenuForHtmlExtensionTests: BaseTests
    {
        private readonly List<SelectListItem> items = new List<SelectListItem> {new SelectListItem("text", "value")};
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DropDownNavigationMenuForHtmlExtension);

        [TestMethod]
        public void DropDownNavigationMenuForTest()
        {
            var obj = new HtmlHelperMock<TrainingTypeView>().DropDownListFor(x => x.Definition, items);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentMock));
        }
    }
}