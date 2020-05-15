using SportClub.Data.Common;

namespace SportClub.Domain.Common
{
    public abstract class Entity<TData> where TData: UniqueEntityData, new()  {
        protected internal Entity(TData d = null) => Data = d;
        public TData Data { get; set; }
    }
}