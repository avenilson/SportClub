using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Common;
using SportClub.Domain.Common;

namespace SportClub.Infra
{
    public abstract class PaginatedRepository<TDomain, TData>: FilteredRepository<TDomain, TData>, IPaging
        where TData: UniqueEntityData, new()
        where TDomain: Entity<TData>, new()
    {
        public int PageIndex { get; set; }
        public int TotalPages => GetTotalPages(PageSize);
        public bool HasNextPage => PageIndex < TotalPages; //lk indeks peab olema vaiksem kui lk arv, siis on veel jargm lk olemas
        public bool HasPreviousPage => PageIndex > 1; //siis on eelm lk olemas
        public int PageSize { get; set; } = 5; //5 kirjet lkl

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public int GetTotalPages(in int pageSize)
        {
            var count = GetItemsCount(); //palju on kirjeid
            var pages = CountTotalPages(count, pageSize);

            return pages;
        }

        public int CountTotalPages(int count, in int pageSize) //internal on nagu private, aga saab testida. keegi valjast ligi ei saa
        {
            return (int)Math.Ceiling(count / (double)pageSize);
        }

        public int GetItemsCount() => base.CreateSqlQuery().CountAsync().Result; //result ehk saame asunkr meetodit kutsuda valja sunkr meetodis

        public override IQueryable<TData> CreateSqlQuery() => AddSkipAndTake(base.CreateSqlQuery()); //lisab skipi (see oli paginatedlist kirjas)

        public IQueryable<TData> AddSkipAndTake(IQueryable<TData> query)
        {
            if (PageIndex < 1) return query;
            return query
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize);
        }
    }
}
