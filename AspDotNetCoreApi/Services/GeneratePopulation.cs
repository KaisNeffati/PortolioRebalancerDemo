using System;
using System.Collections.Generic;
using System.Collections;

using SampleApi.Models;
using Sample.Models;
namespace WebApplication.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
    public class GeneratePopulation : IGeneratePopulation
    {
        private readonly INormalDestribution _normalDestribution;
        public GeneratePopulation(INormalDestribution normalDestribution){
            _normalDestribution=normalDestribution;
        }
        public void Generate(Dictionary<string,double[]> products)
        {
            SampleRepository s =new SampleRepository();
            s.clear();
           foreach(KeyValuePair<string,double[]> item in products)
            {
                _normalDestribution._mi=item.Value[0];
                _normalDestribution._di=item.Value[1];
                ArrayList l=new ArrayList(100);
                for(int j=0;j<100;j++){
                l.Add(_normalDestribution.normalFunction());
                }
                s.Add(new SampleItem {CurrentPrise=_normalDestribution._mi,StandardDeviation=_normalDestribution._di, Values=l});
            }
        }
    }
}
