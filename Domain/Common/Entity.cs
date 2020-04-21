using Abc.Aids;
using SportClub.Data.Common;


namespace SportClub.Domain.Common
{
    public abstract class Entity<TData> where TData: NamedEntityData, new()  {
        protected internal Entity(TData d = null) => Data = d;
        public TData Data { get; internal set; }

        //protected readonly TData data;

        //protected internal Entity(TData d = null) => data = d;

        //public TData Data {
        //    get {
        //        if (data is null) return null;
        //        var d = new TData();
        //        Copy.Members(data, d);

        //        return d;
        //    }
        //}

    }
}