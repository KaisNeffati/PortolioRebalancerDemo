using System.Collections.Generic;

namespace Sample.Models
{
    public interface ISampleRepository
    {
        void Add(SampleItem item);
        IEnumerable<SampleItem> GetAll();
        SampleItem Find(string key);
        SampleItem Remove(string key);

        void clear();
        void Update(SampleItem item);
    }
}
