using Abc.Aids;
using SportClub.Data.Training;

namespace SportClub.Facade.Training
{
     public static class TrainingViewFactory
    {
        public static Domain.Training.Training Create(TrainingView view)
        {
            var d = new TrainingData();
            Copy.Members(view, d);

            return new Domain.Training.Training(d);
        }

        public static TrainingView Create(Domain.Training.Training obj)
        {
            var v = new TrainingView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
