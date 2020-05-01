using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Aids {

    [TestClass] public class IsAidsTested : AssemblyTests {

        protected override string assembly => "SportClub.Aids";

        protected override string Namespace(string name) => $"{assembly}.{name}";

        [TestMethod] public void IsExtensionsTested()
            => IsAllTested(assembly, Namespace("Extensions"));

        [TestMethod] public void IsLoggingTested()
            => IsAllTested(assembly, Namespace("Logging"));

        [TestMethod] public void IsRandomTested()
            => IsAllTested(assembly, Namespace("Random"));

        [TestMethod] public void IsReflectionTested()
            => IsAllTested(assembly, Namespace("Reflection"));

        [TestMethod] public void IsServicesTested()
            => IsAllTested(assembly, Namespace("Services"));

        [TestMethod] public void IsMethodsTested()
            => IsAllTested(assembly, Namespace("Methods"));

        [TestMethod] public void IsRegionsTested()
            => IsAllTested(assembly, Namespace("Regions"));

        [TestMethod]
        public void IsClassesTested()
            => IsAllTested(assembly, Namespace("Classes"));
        [TestMethod]
        public void IsFormatsTested()
            => IsAllTested(assembly, Namespace("Formats"));


    }

}
