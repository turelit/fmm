using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sampleApp.Models;

namespace sampleApp.Services
{
    public class MockDataStore : IDataStore<Dream>
    {
        readonly List<Dream> items;

        public MockDataStore()
        {
            items = new List<Dream>()
            {
                new Dream { Id = Guid.NewGuid(), Title = "First dream", Description="This is a dream description." },
                new Dream { Id = Guid.NewGuid(), Title = "Second dream", Description="This is a dream description." },
                new Dream { Id = Guid.NewGuid(), Title = "Third dream", Description="This is a dream description." },
                new Dream { Id = Guid.NewGuid(), Title = "Fourth dream", Description="This is a dream description." },
                new Dream { Id = Guid.NewGuid(), Title = "Fifth dream", Description="This is a dream description." },
                new Dream { Id = Guid.NewGuid(), Title = "Sixth dream", Description="This is a dream description." }
            };
        }

        public async Task<bool> AddItemAsync(Dream item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Dream item)
        {
            var oldItem = items.Where((Dream arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Dream arg) => arg.Id.Equals(id)).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Dream> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id.Equals(id)));
        }

        public async Task<IEnumerable<Dream>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}