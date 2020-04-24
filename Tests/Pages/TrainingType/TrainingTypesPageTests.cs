using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;
using SportClub.Facade.TrainingType;
using SportClub.Pages;
using SportClub.Pages.Participant;
using SportClub.Pages.TrainingType;

namespace SportClub.Tests.Pages.TrainingType
{
    [TestClass]
    public class TrainingTypesPageTests: AbstractClassTests
        <ParticipantsPage, CommonPage<ITrainingTypesRepository, SportClub.Domain.TrainingType.TrainingType, TrainingTypeView, TrainingTypeData>>
    {
        private class TestClass : TrainingTypesPage
        {
            internal TestClass(ITrainingTypesRepository r) : base(r)
            {
            }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.TrainingType.TrainingType, TrainingTypeData>,
            ITrainingTypesRepository { } 

        //[TestMethod]
        //public void ItemIdTest()
        //{
        //    var item = GetRandom.Object<TrainingTypeView>();
        //    obj.Item = item;C:\Users\Helen\source\repos\SportClub\Tests\Pages\Extensions\
        //    Assert.AreEqual(item.Id, obj.ItemId);
        //    obj.Item = null;
        //    Assert.AreEqual(string.Empty, obj.ItemId);
        //}

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Training Types", obj.PageTitle);

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/TrainingType/TrainingTypes", obj.PageUrl);

    }
}
