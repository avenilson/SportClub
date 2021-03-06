﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Domain.Training;
using SportClub.Facade.ParticipantOfTraining;
using SportClub.Pages;
using SportClub.Pages.ParticipantOfTraining;

namespace SportClub.Tests.Pages.ParticipantOfTraining
{
    [TestClass]
    public class ParticipantOfTrainingsPageTests : AbstractClassTests
        <ParticipantOfTrainingsPage, CommonPage<IParticipantOfTrainingsRepository, SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingView, ParticipantOfTrainingData>>
    {
        private class TestClass : ParticipantOfTrainingsPage
        {
            internal TestClass(IParticipantOfTrainingsRepository r, IParticipantsRepository p, ITrainingsRepository t) : base(r, p, t) { }
        }
        private class TrainRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.Training.Training, TrainingData>,
            ITrainingsRepository { }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>,
            IParticipantOfTrainingsRepository { }

        private class TermRepository : BaseTestRepositoryForNamedEntity<SportClub.Domain.Participant.Participant, ParticipantData>,
            IParticipantsRepository
        {
            protected override bool IsThis(SportClub.Domain.Participant.Participant entity, string id) => true;

            protected override string GetId(SportClub.Domain.Participant.Participant entity) => string.Empty;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            var p = new TermRepository();
            var t = new TrainRepository();
            obj = new TestClass(r, p, t);
        }

        public static string Id(string head, string tail) => $"{head}.{tail}";

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Participant Of Trainings", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/ParticipantOfTraining/ParticipantOfTrainings", obj.PageUrl);

        [TestMethod] public void ToObjectTest()
        {
            var view = GetRandom.Object<ParticipantOfTrainingView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod] public void ToViewTest()
        {
            var data = GetRandom.Object<ParticipantOfTrainingData>();
            var view = obj.ToView(new SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod] public void ParticipantIdTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void TrainingIdTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod] public void GetParticipantNameTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void GetTrainingNameTest()
        {
            var item = GetRandom.Object<ParticipantOfTrainingView>();
            obj.Item = item;
            string a = Id(item.ParticipantId, item.TrainingId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
    }
}
