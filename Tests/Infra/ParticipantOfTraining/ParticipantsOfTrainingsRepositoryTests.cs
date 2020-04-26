﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Aids;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Infra;
using SportClub.Infra.ParticipantOfTraining;

namespace SportClub.Tests.Infra.ParticipantOfTraining
{

    [TestClass]
    public class ParticipantsOfTrainingsRepositoryTests : RepositoryTests<ParticipantOfTrainingsRepository,
        SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext) db).ParticipantsOfTrainings;
            obj = new ParticipantOfTrainingsRepository((SportClubDbContext) db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() =>
            typeof(PaginatedRepository<SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining,
                ParticipantOfTrainingData>);

        protected override string GetId(ParticipantOfTrainingData d) => $"{d.ParticipantId}.{d.TrainingId}";

        protected override SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining
            GetObject(ParticipantOfTrainingData d) =>
            new SportClub.Domain.ParticipantOfTraining.ParticipantOfTraining(d);

        protected override void SetId(ParticipantOfTrainingData d, string id)
        {
            var participantId = GetString.Head(id);
            var trainingId = GetString.Tail(id);
            d.ParticipantId = participantId;
            d.TrainingId = trainingId;
        }
    }
}