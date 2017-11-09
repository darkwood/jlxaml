﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jlxaml
{
    public class MockDataStore : IDataStore<Hunt>
    {
        List<Hunt> items;

        public MockDataStore()
        {
            items = new List<Hunt>();
            var mockItems = new List<Hunt>
            {
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "First location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "Second location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "Third location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "Fourth location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "Fifth location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
                new Hunt { Id = Guid.NewGuid().ToString(), Location = "Sixth location", Notes="This is a note of some length. It can be short, but it can also be of, well, some length." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Hunt item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Hunt item)
        {
            var _item = items.Where((Hunt arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Hunt arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Hunt> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Hunt>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
