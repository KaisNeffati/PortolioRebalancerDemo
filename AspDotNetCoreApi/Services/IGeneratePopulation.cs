using System.Collections.Generic;

namespace WebApplication.Services
{
    public interface IGeneratePopulation
    {
        void Generate(Dictionary<string,double[]> products);
    }
}
