using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Common;
using SportClub.Domain.Common;

namespace SportClub.Tests.Infra
{
    public abstract class UniqueEntityRepository<TDomain, TData>:PaginatedRepository<TDomain, TData>
    where TData: NamedEntityData, new()
    where TDomain: Entity<TData>, new()
    {
        protected UniqueEntityRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
        protected override async Task<TData> getData(string id)
            => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

        protected override string getId(TDomain entity) => entity?.Data?.Id;
    }
}
