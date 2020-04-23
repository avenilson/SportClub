using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Coach;
using SportClub.Facade.Training;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(EditControlsForHtmlExtension);

        [TestMethod]
        public void EditControlsForTest()
        {
            var obj = new HtmlHelperMock<CoachView>().EditControlsFor(x => x.Id);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        //[TestMethod]
        //public void HtmlStringsTest()
        //{
        //    var expected = new List<string> { "<div", "LabelFor", "EditorFor", "ValidationMessageFor", "</div" };
        //    var actual = EditControlsForHtmlExtension.htmlStrings(new HtmlHelperMock<TrainingView>(), x => x.ValidFrom);
        //    TestHtml.Strings(actual, expected);
        //}
    }
}