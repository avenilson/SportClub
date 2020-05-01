using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class LinkTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(Link);

        [TestMethod]
        public void DisplayNameTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UrlTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PropertyNameTest()
        {
            Assert.Inconclusive();
        }
      
    }
}