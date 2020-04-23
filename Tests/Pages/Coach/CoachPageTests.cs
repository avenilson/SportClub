using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Facade.Coach;
using SportClub.Pages;
using SportClub.Pages.Coach;

namespace SportClub.Tests.Pages.Coach
{
    //[TestClass]
    //public class CoachPageTests : AbstractClassTests
    //    <CoachesPage, CommonPage<ICoachesRepository, SportClub.Domain.Coach.Coach, CoachView, CoachData>>
    //{
    //    private class testClass : CoachesPage
    //    {
    //        internal testClass(ICoachesRepository r, ICoachOfTrainingsRepository t) : base(r, t) { }
    //    }

    //    private class testRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Coach.Coach, CoachData>, ICoachesRepository { } //fake repo klass
    //    private class termRepository :  BaseTestRepositoryForNamedEntity<CoachOfTraining, CoachOfTrainingData>,
    //        ICoachOfTrainingsRepository {
    //        protected override bool isThis(CoachOfTraining entity, string id)
    //        {
    //            return true;
    //        }

    //        protected override string getId(CoachOfTraining entity)
    //        {
    //            return string.Empty;
    //        }
    //    }
    //    [TestInitialize]
    //    public override void TestInitialize()
    //    {
    //        base.TestInitialize(); //kasutab inmemorydb extensionit, mis on malus!
    //        var r = new testRepository();
    //        var t = new termRepository();
    //        obj = new testClass(r, t); //annan repository katte
    //    }

    //    [TestMethod] public void ItemIdTest()
    //    {
    //        var item = GetRandom.Object<CoachView>();
    //        obj.Item = item; 
    //        Assert.AreEqual(item.Id, obj.ItemId);
    //        obj.Item = null;
    //        Assert.AreEqual(string.Empty, obj.ItemId);
    //    }

    //    [TestMethod] 
    //    public void PageTitleTest() => Assert.AreEqual("Measures", obj.PageTitle);
        
    //    [TestMethod] 
    //    public void PageUrlTest() => Assert.AreEqual("/Quantity/Measures", obj.PageUrl);

    //    [TestMethod] public void ToObjectTest()
    //    {
    //        var view = GetRandom.Object<CoachView>();
    //        var o = obj.toObject(view);
    //        testArePropertyValuesEqual(view, o.Data);
    //    }
    //    [TestMethod] public void ToViewTest()
    //    {
    //        var data = GetRandom.Object<CoachData>();
    //        var view = obj.toView(new SportClub.Domain.Coach.Coach(data));
    //        testArePropertyValuesEqual(view, data);
    //    }
    //    [TestMethod] public void LoadDetailsTest()
    //    {
    //        var v = GetRandom.Object<CoachView>();
    //       obj.LoadDetails(v);
    //       Assert.IsNotNull(obj.Terms);
    //    }
    //    [TestMethod] public void TermsTest()
    //    {
    //        isReadOnlyProperty(obj, nameof(obj.Terms), obj.Terms);
    //    }

    //}
}
