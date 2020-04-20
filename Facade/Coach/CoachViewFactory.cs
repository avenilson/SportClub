using System;
using System.Collections.Generic;
using System.Text;
using Abc.Aids;
using SportClub.Data.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Facade.Coach
{
    public class CoachViewFactory
    {
        public static Coach Create(CoachView view)
        {
            var d = new ParticipantData();
            Copy.Members(view, d);

            return new Coach(d);
        }

        public static ParticipantView Create(CoachView obj)
        {
            var v = new ParticipantView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
