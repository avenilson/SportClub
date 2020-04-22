using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;

namespace SportClub.Tests.Pages {

    [TestClass]
    public class CrudPageTests : AbstractPageTests<CrudPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>,
        BasePage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>> {

        private string fixedFilter;
        private string fixedValue;

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new TestClass(db);
            fixedFilter = GetRandom.String();
            fixedValue = GetRandom.String();
            Assert.AreEqual((object) null, obj.FixedValue);
            Assert.AreEqual((object) null, obj.FixedFilter);
        }

        [TestMethod] public void ItemTest() {
            isProperty(() => obj.Item, x => obj.Item = x);
        }

        [TestMethod] public void AddObjectTest() {
            var idx = db.list.Count;
            obj.Item = GetRandom.Object<TrainingView>();
            obj.addObject(fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(fixedFilter, obj.FixedFilter);
            Assert.AreEqual(fixedValue, obj.FixedValue);
            testArePropertyValuesEqual(obj.Item, db.list[idx].Data);
        }

        [TestMethod] public void UpdateObjectTest() {
            GetObjectTest();
            var idx = GetRandom.Int32(0, db.list.Count);
            var itemId = db.list[idx].Data.Id;
            obj.Item = GetRandom.Object<TrainingView>();
            obj.Item.Id = itemId;
            obj.updateObject(fixedFilter, fixedValue).GetAwaiter();
            testArePropertyValuesEqual(db.list[^1].Data, obj.Item);
        }

        [TestMethod] public void GetObjectTest() {
            var count = GetRandom.UInt8(5, 10);
            var idx = GetRandom.UInt8(0, count);
            for (var i = 0; i < count; i++) AddObjectTest();
            var item = db.list[idx];
            obj.getObject(item.Data.Id, fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(count, db.list.Count);
            testArePropertyValuesEqual(item.Data, obj.Item);
        }

        [TestMethod] public void DeleteObjectTest() {
            AddObjectTest();
            obj.deleteObject(obj.Item.Id, fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(fixedFilter, obj.FixedFilter);
            Assert.AreEqual(fixedValue, obj.FixedValue);
            Assert.AreEqual(0, db.list.Count);
        }

        [TestMethod] public void ToViewTest() {
            var d = GetRandom.Object<TrainingData>();
            var v = obj.toView(new SportClub.Domain.Training.Training(d));
            testArePropertyValuesEqual(d, v);
        }

        [TestMethod] public void ToObjectTest() {
            var v = GetRandom.Object<TrainingView>();
            var o = obj.toObject(v);
            testArePropertyValuesEqual(v, o.Data);
        }

    }

}
