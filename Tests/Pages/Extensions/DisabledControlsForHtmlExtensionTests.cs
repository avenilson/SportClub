using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Coach;
using SportClub.Facade.Training;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DisabledControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DisabledControlsForHtmlExtension);

        [TestMethod]
        public void DisabledControlsForTest()
        {
            var obj = new HtmlHelperMock<CoachView>().DisabledControlsFor(x => x.Id); //kas oige
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        [TestMethod]
        public void htmlStringsTest()
        {
            var expected = new List<string> { "<div", "<fieldset disabled>", "LabelFor", "EditorFor", "ValidationMessageFor", "</fieldset>", "</div" };
            var actual = DisabledControlsForHtmlExtension.htmlStrings(new HtmlHelperMock<TrainingView>(), x => x.Duration);
            TestHtml.Strings(actual, expected);
        }
    }
}
