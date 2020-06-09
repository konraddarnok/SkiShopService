using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SkiShopService.Models;

namespace SkiShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiController : ControllerBase
    {

        private static readonly List<Ski> ListOfSki = new List<Ski>()
        {
            new Ski(1, 200, "Slalom", 5000),
               new Ski(2, 190, "Slalom", 4500),
                  new Ski(3, 180, "CrossCountry", 3500),
                     new Ski(4, 190, "Freestyle", 4000),
                      new Ski(5, 190, "Downhill", 5000),

        };
        
        
        // GET: api/Ski
        [HttpGet]
        public IEnumerable<Ski> Get()
        {
            
            return ListOfSki;
        }

        // GET: api/Ski/5
        [HttpGet("{id}", Name = "Get")]
        public Ski Get(int id)
        {

            return ListOfSki.Find(i => i.Id == id);
        }

        // POST: api/Ski
        [HttpPost]
        public void Post([FromBody] Ski value)
        {
            ListOfSki.Add(value);
        }

        // PUT: api/Ski/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ski value)
          
        {
            Ski ski = Get(id);
            if (ski != null)
            {
                ski.Id = value.Id;
              
                ski.SkiLength = value.SkiLength;
                ski.SkiType = value.SkiType;
                 ski.Price = value.Price;

            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Ski ski = Get(id);
            ListOfSki.Remove(ski);
        }
    }
}
