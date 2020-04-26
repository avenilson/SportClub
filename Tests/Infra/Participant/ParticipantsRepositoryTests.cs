using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportClub.Data.Participant;
using SportClub.Infra;
using SportClub.Infra.Participant;

namespace SportClub.Tests.Infra.Participant
{
    [TestClass]
    public class ParticipantsRepositoryTests : RepositoryTests<ParticipantsRepository, SportClub.Domain.Participant.Participant, ParticipantData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SportClubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SportClubDbContext(options);
            dbSet = ((SportClubDbContext)db).Participants;
            obj = new ParticipantsRepository((SportClubDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<SportClub.Domain.Participant.Participant, ParticipantData>);

        protected override string GetId(ParticipantData d) => d.Id;

        protected override SportClub.Domain.Participant.Participant GetObject(ParticipantData d) => new SportClub.Domain.Participant.Participant(d);

        protected override void SetId(ParticipantData d, string id) => d.Id = id;
    }
}
