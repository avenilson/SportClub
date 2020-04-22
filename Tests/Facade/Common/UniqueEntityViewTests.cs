using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Common;

namespace SportClub.Tests.Facade.Common
{
    class UniqueEntityViewTests : AbstractClassTests<NamedView, UniqueEntityView>
    {
        private class TestClass : NamedView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod]
        public void IdTest()
        {
            IsNullableProperty(() => obj.Id, x => obj.Id = x);
        }
    }
}