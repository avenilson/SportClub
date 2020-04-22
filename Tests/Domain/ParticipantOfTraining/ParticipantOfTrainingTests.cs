using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Domain.Common;

namespace SportClub.Tests.Domain.ParticipantOfTraining
{
    [TestClass] public class ParticipantOfTrainingTests: SealedClassTests<SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, Entity<ParticipantOfTrainingData>> { }
}
