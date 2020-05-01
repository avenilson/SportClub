using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Aids {

    [TestClass] public class IsAidsTested : AssemblyTests {

        protected override string assembly => "SportClub";

        protected override string Namespace(string name) => $"{assembly}.{name}";


        [TestMethod] public void IsLoggingTested()
            => IsAllTested(assembly, Namespace("Aids"));
        

    }

}
