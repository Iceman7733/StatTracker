using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatTrackerAPI.Models;
using StatTrackerAPI.Persistence;

namespace StatTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IStatRepository _statRepository;

        public ValuesController(IStatRepository statRepository)
        {
            _statRepository = statRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void AddRoster(string value)
        {
            if(value != null)
                _statRepository.CreateRoster(value);
        }

        [HttpPost]
        public void AddPlayer(Player data)
        {
            Console.Write("rrrowwww");
        }

        [HttpPost]
        public void AddPlayer2(string data)
        {
            Console.Write("rrrowwww");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
