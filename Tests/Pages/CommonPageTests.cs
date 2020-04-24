using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;

namespace SportClub.Tests.Pages
{

    [TestClass]
    public class CommonPageTests
        : AbstractPageTests<CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>
            , PaginatedPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>>
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(new TestRepository());
        }

        [TestMethod]
        public void ItemIdTest()
        {
            obj.Item = GetRandom.Object<TrainingView>();
            Assert.AreEqual(obj.Item.Id, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest()
        {
            IsNullableProperty(() => obj.PageTitle, x => obj.PageTitle = x);
        }

        [TestMethod]
        public void PageSubTitleTest()
        {
            isReadOnlyProperty(obj, nameof(obj.PageSubTitle), obj.GetPageSubTitle());
        }

        [TestMethod]
        public void GetPageSubTitleTest()
        {
            Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
        }

        [TestMethod]
        public void PageUrlTest()
        {
            isReadOnlyProperty(obj, nameof(obj.PageUrl), obj.GetPageUrl());
        }

        [TestMethod]
        public void GetPageUrlTest()
        {
            Assert.AreEqual(obj.PageUrl, obj.GetPageUrl());
        }

        [TestMethod]
        public void IndexUrlTest()
        {
            isReadOnlyProperty(obj, nameof(obj.IndexUrl), obj.GetIndexUrl());
        }

        [TestMethod]
        public void GetIndexUrlTest()
        {
            Assert.AreEqual(obj.IndexUrl, obj.GetIndexUrl());
        }

    }

}
