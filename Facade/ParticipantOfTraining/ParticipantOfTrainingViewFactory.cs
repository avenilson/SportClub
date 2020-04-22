using SportClub.Aids;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Facade.Participant;

namespace SportClub.Facade.ParticipantOfTraining
{
    public static class ParticipantOfTrainingViewFactory
    {
        public static Domain.ParticipantOfTraining.ParticipantOfTraining Create(ParticipantOfTrainingView view)
        {
            var d = new ParticipantOfTrainingData();
            Copy.Members(view, d);

            return new Domain.ParticipantOfTraining.ParticipantOfTraining(d);
        }

        public static ParticipantOfTrainingView Create(Domain.ParticipantOfTraining.ParticipantOfTraining obj)
        {
            var v = new ParticipantOfTrainingView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
