﻿using System;
using System.Collections.Generic;
using System.Text;
using Abc.Aids;
using SportClub.Data.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Facade.TrainingType
{
    public class TrainingTypeViewFactory
    {
        public static Participant Create(ParticipantView view)
        {
            var d = new ParticipantData();
            Copy.Members(view, d);

            return new Participant(d);
        }

        public static ParticipantView Create(Participant obj)
        {
            var v = new ParticipantView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
