using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Domain.Coach;
using SportClub.Facade.Coach;

namespace SportClub.Tests.Aids.Reflection {

    [TestClass] public class GetMemberTests : BaseTests {

        [TestInitialize] public void TestInitialize() => type = typeof(GetMember);

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual("Data", GetMember.Name<Coach>(o => o.Data));
            Assert.AreEqual("Name", GetMember.Name<CoachData>(o => o.Name));
            Assert.AreEqual("NameTest", GetMember.Name<GetMemberTests>(o => o.NameTest()));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Func<CoachData, object>>)null));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Action<CoachData>>)null));
        }

        [TestMethod] public void DisplayNameTest() {
            Assert.AreEqual("Name", GetMember.DisplayName<CoachView>(o => o.Name));
            Assert.AreEqual(string.Empty, GetMember.DisplayName<CoachView>(null));
            //Impossible to use for methods
            //Assert.AreEqual(string.Empty, GetMember.DisplayName<GetMemberTests>(o => o.NameTest()));
        }

    }

}


