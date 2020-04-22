using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Facade.Common;
using SportClub.Facade.TrainingType;

namespace SportClub.Tests.Facade.TrainingType
{
    [TestClass]
    public class TrainingTypeViewTests : SealedClassTests<TrainingTypeView, NamedView>
    {
        [TestMethod]
        public void TypeTest() => IsNullableProperty(() => obj.Type, x => obj.Type = x);
    }
}
