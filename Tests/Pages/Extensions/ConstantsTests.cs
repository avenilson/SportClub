using SportClub.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportClub.Tests.Pages.Extensions
{
    [TestClass]
    public class ConstantsTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(Constants);

        [TestMethod] public void UnspecifiedTest() => Assert.AreEqual("Unspecified", Constants.Unspecified);

        [TestMethod] public void CreateNewLinkTitleTest() => Assert.AreEqual("Create New", Constants.CreateNewLinkTitle);
        [TestMethod] public void EditLinkTitleTest() => Assert.AreEqual( "Edit", Constants.EditLinkTitle);
        [TestMethod] public void DetailsLinkTitleTest() => Assert.AreEqual( "Details", Constants.DetailsLinkTitle);
        [TestMethod] public void CoachesPageTitleTest() => Assert.AreEqual( "Coaches", Constants.CoachesPageTitle);
        [TestMethod] public void  CoachOfTrainingsPageTitleTest() => Assert.AreEqual( "Coach of Trainings", Constants.CoachOfTrainingsPageTitle);
        [TestMethod] public void  ParticipantsPageTitleTest() => Assert.AreEqual( "Participants", Constants.ParticipantsPageTitle);
        [TestMethod] public void  ParticipantOfTrainingsPageTitleTest() => Assert.AreEqual( "Participant of Trainings", Constants.ParticipantOfTrainingsPageTitle);
        [TestMethod] public void  TrainingPageTitleTest() => Assert.AreEqual( "Trainings", Constants.TrainingPageTitle);
        [TestMethod] public void  TrainingTypesPageTitleTest() => Assert.AreEqual( "Training Types", Constants.TrainingTypesPageTitle);
        [TestMethod] public void DeleteLinkTitleTest() => Assert.AreEqual( "Delete", Constants.DeleteLinkTitle);
    }
}
