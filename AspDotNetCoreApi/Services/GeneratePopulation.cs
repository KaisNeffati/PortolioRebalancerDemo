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
        public void Generate(Dictionary<double,double> products)
        {
            
            SampleRepository s =new SampleRepository();
            s.clear();
            ArrayList a=new ArrayList();
           foreach(KeyValuePair<double, double> item in products)
            {
                _normalDestribution._mi=item.Key;
                _normalDestribution._di=item.Value;
                for(int i=0;i<100;i++){
                    a.Add(_normalDestribution.normalFunction());
                }
                s.Add(new SampleItem { Values=a });
            }
        }
    }
}
