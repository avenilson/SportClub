﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SportClub.Data.Common;
using SportClub.Domain.Common;

namespace SportClub.Tests
{
    internal class BaseTestRepositoryForUniqueEntity<TObj, TData> 
        where TObj: Entity<TData>
        where TData: UniqueEntityData, new()
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
        public string FixedFilter { get; set; }
        public string FixedValue { get; set; }

        internal readonly List<TObj> list;

        public BaseTestRepositoryForUniqueEntity() => list = new List<TObj>();

        public async Task<List<TObj>> Get()
        {
            await Task.CompletedTask;
            return list;
        }

        public async Task<TObj> Get(string id)
        {
            await Task.CompletedTask;
            return list.Find(x => x.Data.Id == id);
        }

        public async Task Delete(string id)
        {
            await Task.CompletedTask;
            var obj = list.Find(x => x.Data.Id == id);
            list.Remove(obj);
        }

        public async Task Add(TObj obj)
        {
            await Task.CompletedTask;
            list.Add(obj);
        }

        public async Task Update(TObj obj)
        {
            await Delete(obj.Data.Id);
            list.Add(obj);
        }
    }
}