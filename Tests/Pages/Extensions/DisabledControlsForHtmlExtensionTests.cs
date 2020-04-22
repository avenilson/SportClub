﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DisabledControlsForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DisabledControlsForHtmlExtension);

        [TestMethod]
        public void DisabledControlsForTest()
        {
            var obj = new HtmlHelperMock<UnitView>().DisabledControlsFor(x => x.MeasureId);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        [TestMethod]
        public void HtmlStringsTest()
        {
            var expected = new List<string> {"<div", "<fieldset disabled>", "LabelFor", "EditorFor", "ValidationMessageFor",  "</fieldset>", "</div"};
            var actual = DisabledControlsForHtmlExtension.htmlStrings(new HtmlHelperMock<MeasureView>(),x=>x.ValidFrom);
            TestHtml.Strings(actual, expected);
        }
    }
}
