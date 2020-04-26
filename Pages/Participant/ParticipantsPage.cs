using SportClub.Data.Participant;
using SportClub.Domain.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Pages.Participant
{
    public abstract class ParticipantsPage : CommonPage<IParticipantsRepository, Domain.Participant.Participant, ParticipantView, ParticipantData>
    {
        protected internal ParticipantsPage(IParticipantsRepository r) : base(r)
        {
            PageTitle = "Participants";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/Participant/Participants";

        public override Domain.Participant.Participant ToObject(ParticipantView view)
        {
            return ParticipantViewFactory.Create(view);
        }

        public override ParticipantView ToView(Domain.Participant.Participant obj)
        {
            return ParticipantViewFactory.Create(obj);
        }

    }

}