using System;
using System.Collections.Generic;
using System.Text;
using SportClub.Aids;
using SportClub.Data.Participant;

namespace SportClub.Facade.Participant
{
    public static class ParticipantViewFactory
    {
        public static Domain.Participant.Participant Create(ParticipantView view)
        {
            var d = new ParticipantData();
            Copy.Members(view, d);

            return new Domain.Participant.Participant(d);
        }

        public static ParticipantView Create(Domain.Participant.Participant obj)
        {
            var v = new ParticipantView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
