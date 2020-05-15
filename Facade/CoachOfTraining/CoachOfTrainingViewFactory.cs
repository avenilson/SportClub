using SportClub.Aids;
using SportClub.Data.CoachOfTraining;

namespace SportClub.Facade.CoachOfTraining
{
    public static class CoachOfTrainingViewFactory
    {
        public static Domain.CoachOfTraining.CoachOfTraining Create(CoachOfTrainingView view)
        {
            var d = new CoachOfTrainingData();
            Copy.Members(view, d);

            return new Domain.CoachOfTraining.CoachOfTraining(d);
        }
        public static CoachOfTrainingView Create(Domain.CoachOfTraining.CoachOfTraining obj)
        {
            var v = new CoachOfTrainingView();
            Copy.Members(obj.Data, v);

            return v;
        }
    }
}
