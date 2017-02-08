using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using System;

using WebApplication.Services;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private readonly IGeneratePopulation _generatePopulation;

        public SampleController(ISampleRepository sampleItems,IGeneratePopulation generatePopulation)
        {
            SampleItems = sampleItems;
            _generatePopulation=generatePopulation;
        }
        public ISampleRepository SampleItems { get; set; }
        
        [HttpGet]
        public IEnumerable<SampleItem> GetAll()
        {
           Dictionary<string,double[]> products=new Dictionary<string,double[]>();
           products.Add(Guid.NewGuid().ToString(),new double[]{0.4,0.3});
           products.Add(Guid.NewGuid().ToString(),new double[]{1.9,0.5,});
            _generatePopulation.Generate(products);
            return SampleItems.GetAll();
        }

        [HttpGet("{id}", Name = "GetSample")]
        public IActionResult GetById(string id)
        {
            var item = SampleItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
