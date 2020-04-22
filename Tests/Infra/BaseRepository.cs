﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportClub.Data.Common;
using SportClub.Domain.Common;

namespace SportClub.Tests.Infra
{
    public abstract class BaseRepository<TDomain, TData>: ICrudMethods<TDomain> 
        where TData: NamedEntityData, new() 
        where TDomain: Entity<TData>,new()
    {
        protected internal DbContext db;
        protected internal DbSet<TData> dbSet;

        protected BaseRepository(DbContext c, DbSet<TData> s)
        {
            db = c;
            dbSet = s;
        }

        public virtual async Task<List<TDomain>> Get()
        {
            var query = createSqlQuery(); 
            var set = await RunSqlQueryAsync(query);
            return ToDomainObjectsList(set);
        }

        internal List<TDomain> ToDomainObjectsList(List<TData> set)
            => set.Select(ToDomainObject).ToList();

        protected internal abstract TDomain ToDomainObject(TData periodData);

        internal async Task<List<TData>> RunSqlQueryAsync(IQueryable<TData> query)
            => await query.AsNoTracking().ToListAsync();
        
        protected internal virtual IQueryable<TData> createSqlQuery()
        {
            var query =from s in dbSet select s; //sql paring
            return query;
        }

        public async Task<TDomain> Get(string id)
        {
            if (id is null) return new TDomain();
            var d = await getData(id);
            var obj = ToDomainObject(d);
            return obj;
        }

        protected abstract Task<TData> getData(string id);

        public async Task Delete(string id) 
        {
            if (id is null) return;

            var v = await getData(id);

            if (v is null) return;
            dbSet.Remove(v);
            await db.SaveChangesAsync();
        }

        public async Task Add(TDomain obj)
        {
            if (obj?.Data is null) return;
            dbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Update(TDomain obj)
        {
            if (obj is null) return;

            var v = await getData(getId(obj));

            if (v is null) return;
            dbSet.Remove(v);
            dbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        protected abstract string getId(TDomain entity);
    }
}