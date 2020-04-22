using SportClub.Aids;
using SportClub.Data.TrainingType;

namespace SportClub.Facade.TrainingType
{
    public static class TrainingTypeViewFactory
    {
        public static Domain.TrainingType.TrainingType Create(TrainingTypeView view)
        {
            var d = new TrainingTypeData();
            Copy.Members(view, d);

            return new Domain.TrainingType.TrainingType(d);
        }

        public static TrainingTypeView Create(Domain.TrainingType.TrainingType obj)
        {
            var v = new TrainingTypeView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
