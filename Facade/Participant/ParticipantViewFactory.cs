using System;
using System.Collections.Generic;
using System.Text;
using SportClub.Data.Participant;

namespace SportClub.Facade.Participant
{
    public class ParticipantViewFactory
    {
        public static Participant Create(ParticipantView view)
        {
            var d = new ParticipantData();
            Copy.Members(view, d);

            return new Participant(d);
        }

        public static MeasureTermView Create(MeasureTerm obj)
        {
            var v = new MeasureTermView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
