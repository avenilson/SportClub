using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Domain.Quantity;

namespace SportClub.Infra.Quantity
{
    public class TrainingsRepository: ITrainingsRepository
    {
        private readonly QuantityDbContext db;

        public TrainingsRepository(QuantityDbContext c)
        {
            db = c; //saab konteksti kátte
        }

        public async Task<List<Training>> Get()
        {
            var l = await db.Trainings.ToListAsync();
            var list = new List<Training>();
            foreach (var e in l) list.Add(new Training(e));
            return list;
        }

        public async Task<Training> Get(string id)
        {
            var d = await db.Trainings.FirstOrDefaultAsync(m => m.Id == id);
            return new Training(d);
        }

        public async Task Delete(string id)
        {
            var d = await db.Trainings.FindAsync(id);

            if (d is null) return;

            db.Trainings.Remove(d);
            await db.SaveChangesAsync();
        }

        public async Task Add(Training obj)
        {
            db.Trainings.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Update(Training obj)
        {
            var d = await db.Trainings.FirstOrDefaultAsync(x => x.Id == obj.Data.Id);
            d.Name = obj.Data.Name;
            d.Definition = obj.Data.Definition;
            d.CoachName = obj.Data.CoachName;
            d.StartTime = obj.Data.StartTime;
            d.EndTime = obj.Data.EndTime;

            db.Trainings.Update(d);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!TrainingViewExists(TrainingView.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

        }
    }
}
