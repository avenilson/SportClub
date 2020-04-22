using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Pages
{
    [TestClass]
    public class IsPagesTested : AssemblyTests
    {
        private const string assembly = "SportClub.Pages";

        protected override string Namespace(string name)
        {
            return $"{assembly}.{name}"; 
        }

        [TestMethod]
        public void IsExtensionsTested()
        {
            isAllTested(assembly, Namespace("Extensions")); 
        }

        [TestMethod]
        public void IsCoachTested()
        {
            isAllTested(assembly, Namespace("Coach")); 
        }
        [TestMethod]
        public void IsTrainingTested()
        {
            isAllTested(assembly, Namespace("Training")); 
        }

        [TestMethod]
        public void IsTested()
        {
            isAllTested(base.Namespace("Pages")); 
        }
    }
}
