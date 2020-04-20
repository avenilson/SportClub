using Abc.Aids;
using SportClub.Data.Participant;
using SportClub.Facade.Participant;

namespace SportClub.Facade.CoachOfTraining
{
    public class CoachOfTrainingViewFactory
    {
        public static CoachOfTraining Create(CoachOfTrainingView view)
        {
            var d = new ParticipantData();
            Copy.Members(view, d);

            return new CoachOfTraining(d);
        }

        public static CoachOfTraining Create(CoachOfTrainingView obj)
        {
            var v = new CoachOfTrainingView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
