using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using Sample.Models;

namespace SampleApi.Models
{
    public class SampleRepository : ISampleRepository
    {
        private static ConcurrentDictionary<string, SampleItem> _samples =
              new ConcurrentDictionary<string, SampleItem>();

        public SampleRepository()
        {
        }

        public IEnumerable<SampleItem> GetAll()
        {
            return _samples.Values;
        }

        public void Add(SampleItem item)
        {
            item.Key = Guid.NewGuid().ToString();
            _samples[item.Key] = item;
        }

        public SampleItem Find(string key)
        {
            SampleItem item;
            _samples.TryGetValue(key, out item);
            return item;
        }

        public SampleItem Remove(string key)
        {
            SampleItem item;
            _samples.TryRemove(key, out item);
            return item;
        }

        public void clear()
        {
            _samples.Clear();
        }

        public void Update(SampleItem item)
        {
            _samples[item.Key] = item;
        }
    }
}
