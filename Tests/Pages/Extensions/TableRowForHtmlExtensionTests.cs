using System;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Facade.Coach;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests: BaseTests
    {
      [TestInitialize] public virtual void TestInitialize() => type = typeof(TableRowForHtmlExtension);

        [TestMethod]
        public void TableRowForTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TableRowWithSelectForTest()
        {
            Assert.Inconclusive();
        }
    }
}