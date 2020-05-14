﻿using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Coach;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class DetailsTableForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DetailsTableForHtmlExtension);
        [TestMethod] public void DetailsTableForTest()
        {
            Assert.Inconclusive();
        }
    }
}
