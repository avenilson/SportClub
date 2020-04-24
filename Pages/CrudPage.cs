using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportClub.Domain.Common;

namespace SportClub.Pages
{
     public abstract class CrudPage<TRepository, TDomain, TView, TData> :
        BasePage<TRepository, TDomain, TView, TData>
        where TRepository : ICrudMethods<TDomain>, ISorting, IFiltering, IPaging {

        protected CrudPage(TRepository r) : base(r) { }

        [BindProperty]
        public TView Item { get; set; }

        public async Task<bool> AddObject(string fixedFilter, string fixedValue) {
            SetFixedFilter(fixedFilter, fixedValue);

            try {
                if (!ModelState.IsValid) return false;
                await db.Add(ToObject(Item));
            }
            catch { return false; }

            return true;
        }

        public async Task<bool> UpdateObject(string fixedFilter, string fixedValue) {
            SetFixedFilter(fixedFilter, fixedValue);

            try {
                if (!ModelState.IsValid) return false;
                await db.Update(ToObject(Item));
            }
            catch { return false; }

            return true;
        }

        public async Task<bool> UpdateObject(string id, string fixedFilter, string fixedValue)
        {
            SetFixedFilter(fixedFilter, fixedValue);

            try
            {
                if (!ModelState.IsValid) return false;
                await db.Delete(id);
                await db.Add(ToObject(Item));
            }
            catch { return false; }

            return true;
        }

        public async Task GetObject(string id, string fixedFilter, string fixedValue) {
            SetFixedFilter(fixedFilter, fixedValue);
            var o = await db.Get(id);
            Item = ToView(o);
        }

        public async Task GetObject(string id, string sortOrder, string searchString, int pageIndex, string fixedFilter, string fixedValue) {
            SetPageValues(sortOrder, searchString, pageIndex);
            SetFixedFilter(fixedFilter, fixedValue);
            var o = await db.Get(id);
            Item = ToView(o);
        }

        public async Task DeleteObject(string id, string fixedFilter, string fixedValue) {
            SetFixedFilter(fixedFilter, fixedValue);
            await db.Delete(id);
        }

        public abstract TDomain ToObject(TView view);

        public abstract TView ToView(TDomain obj);


    }
}
