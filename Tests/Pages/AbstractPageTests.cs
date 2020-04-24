using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Training;
using SportClub.Domain.Training;
using SportClub.Facade.Training;
using SportClub.Pages;

namespace SportClub.Tests.Pages {

    public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
        where TClass : BasePage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>
    {

        internal TestRepository db;
        internal class TestClass : CommonPage<ITrainingsRepository, SportClub.Domain.Training.Training, TrainingView, TrainingData>
        {

            protected internal TestClass(ITrainingsRepository r) : base(r)
            {
                PageTitle = "Trainings";
            }

            public override string ItemId => Item?.Id ?? string.Empty;

            public override string GetPageUrl() => "/Training/Trainings";

            public override SportClub.Domain.Training.Training ToObject(TrainingView view) => TrainingViewFactory.Create(view);

            public override TrainingView ToView(SportClub.Domain.Training.Training obj) => TrainingViewFactory.Create(obj);

        }

        internal class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>, ITrainingsRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            db = new TestRepository();
        }

    }

}
