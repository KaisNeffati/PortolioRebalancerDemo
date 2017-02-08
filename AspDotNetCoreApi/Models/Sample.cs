using System.Collections;
namespace Sample.Models
{
    public class SampleItem
    {
        public string Key { get; set; }
        public double CurrentPrise { get; set; }
        public double StandardDeviation  { get; set; }
        
        public ArrayList Values { get; set; }
    }
}