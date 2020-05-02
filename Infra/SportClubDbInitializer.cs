using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportClub.Core.Trainings;
using SportClub.Data.TrainingType;

namespace SportClub.Infra
{
    public static class SportClubDbInitializer
    {
        public static void Initialize(SportClubDbContext db)
        {
            Initialize(TrainingTypes.Trainings, db);
        }

        private static void Initialize(List<Core.Trainings.Data> data, SportClubDbContext db)
        {
            foreach (var d in from d in data
                              let o = db.TrainingTypes.FirstOrDefaultAsync(t => t.Id == d.Id).GetAwaiter().GetResult()
                              where o is null
                              select d)
            {
                db.TrainingTypes.Add(
                    new TrainingTypeData
                    {
                        Id = d.Id,
                        Name = d.Name,
                        Definition = d.Definition,
                        Type = d.Type
                    });
            }
        }
    }
}

