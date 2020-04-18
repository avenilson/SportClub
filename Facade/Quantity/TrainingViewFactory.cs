using SportClub.Data.Quantity;
using SportClub.Domain.Quantity;

namespace SportClub.Facade.Quantity
{
    public static class TrainingViewFactory
    {
        public static Training Create(TrainingView v)
        {
            var d = new TrainingData
            {
                Id = v.Id,
                Name = v.Name,
                Definition = v.Definition,
                CoachName = v.CoachName,
                StartTime = v.StartTime,
                EndTime = v.EndTime
            };
            return new Training(d);
        }

        public static TrainingView Create(Training o)
        {
            var v = new TrainingView
            {
                Id = o.Data.Id,
                Name = o.Data.Name,
                Definition = o.Data.Definition,
                CoachName = o.Data.CoachName,
                StartTime = o.Data.StartTime,
                EndTime = o.Data.EndTime
            };
            return v;

        }
    }
}
