using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Facade.Common;
using SportClub.Pages.Extensions;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForEnumHtmlExtensionTests: BaseTests
    {
        private class TestClass : NamedView
        {
            public IsoGender Gender { get; set; }
        }
        [TestInitialize] public virtual void TestInitialize() => type = typeof(EditControlsForEnumHtmlExtension);

        [TestMethod]
        public void EditControlsForEnumTest()
        {
            var obj = new HtmlHelperMock<TestClass>().EditControlsForEnum(x => x.Gender);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}