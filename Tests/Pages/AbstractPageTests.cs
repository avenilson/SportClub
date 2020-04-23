using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;

namespace SportClub.Tests.Pages {

    //public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
    //    where TClass : BasePage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData> {

    //    internal TestRepository db; 
    //    internal class TestClass : CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData> {

    //        protected internal TestClass(ITrainingsRepository r) : base(r) {
    //            PageTitle = "Measures";
    //        }

    //        public override string ItemId => Item?.Id ?? string.Empty;

    //        protected internal override string getPageUrl() => "/Training/Trainings";

    //        protected internal override SportClub.Domain.Training.Training toObject(TrainingView view) => TrainingViewFactory.Create(view);

    //        protected internal override TrainingView toView(SportClub.Domain.Training.Training obj) => TrainingViewFactory.Create(obj);

    //    }

    //    internal class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>, ITrainingsRepository { }

    //    [TestInitialize]
    //    public override void TestInitialize()
    //    {
    //        base.TestInitialize();
    //        db = new TestRepository();
    //    }

    //}

}
