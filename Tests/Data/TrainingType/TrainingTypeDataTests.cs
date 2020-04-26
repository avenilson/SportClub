using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Common;
using SportClub.Data.TrainingType;

namespace SportClub.Tests.Data.TrainingType
{
    [TestClass]
    public class TrainingTypeDataTests : SealedClassTests<TrainingTypeData, NamedEntityData>
    {
        [TestMethod]
        public void TypeTest() => IsNullableProperty(() => obj.Type, x => obj.Type = x);

        [TestMethod]
        public void DefinitionTest() => IsNullableProperty(() => obj.Definition, x => obj.Definition = x);
    }
}
