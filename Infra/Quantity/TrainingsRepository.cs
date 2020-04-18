using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Quantity;
using SportClub.Domain.Quantity;

namespace SportClub.Infra.Quantity
{
    public class TrainingsRepository: ITrainingsRepository
    {
        private readonly QuantityDbContext db;
        public string SortOrder { get; set; }
        public string SearchString { get; set; }

        public TrainingsRepository(QuantityDbContext c)
        {
            db = c; //saab konteksti kátte
        }

        public async Task<List<Training>> Get()
        {
            var list = await CreateFiltered(CreateSorted()).ToListAsync();
            return list.Select(e => new Training(e)).ToList();
        }

        private IQueryable<TrainingData> CreateFiltered(IQueryable<TrainingData> set)
        {
            if (!string.IsNullOrEmpty(SearchString)) return set;
            return set.Where(s => s.Name.Contains(SearchString)
                                    || s.Id.Contains(SearchString)
                                    || s.Definition.Contains(SearchString)
                                    || s.CoachName.Contains(SearchString)
                                    || s.StartTime.ToString().Contains(SearchString)
                                    || s.EndTime.ToString().Contains(SearchString));
            
        }

        private IQueryable<TrainingData> CreateSorted()
        {
            IQueryable<TrainingData> trainings = from s in db.Trainings select s;

            switch (SortOrder)
            {
                case "name_desc":
                    trainings = trainings.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    trainings = trainings.OrderBy(s => s.StartTime);
                    break;
                case "date_desc":
                    trainings = trainings.OrderByDescending(s => s.EndTime);
                    break;
                default:
                    trainings = trainings.OrderBy(s => s.Name);
                    break;
            }
            return trainings.AsNoTracking();
        }

        public async Task<Training> Get(string id)
        {
            var d = await db.Trainings.FirstOrDefaultAsync(m => m.Id == id);
            return new Training(d);
        }

        public async Task Delete(string id)
        {
            if (id is null) return;

            var v = await db.Trainings.FindAsync(id);

            if (v is null) return;
            db.Trainings.Remove(v);
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
