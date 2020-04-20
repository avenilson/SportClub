using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportClub.Domain.Common
{
    public interface IRepository<T> : ICrudMethods<T>, ISorting, IFiltering, IPaging
    {
    }
}