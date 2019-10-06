using Microsoft.AspNetCore.Mvc;
using StatTrackerAPI.Models;
using StatTrackerAPI.Persistence;
using System;
using System.Collections.Generic;

namespace StatTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private IStatRepository _statRepository;

        public PlayersController(IStatRepository statRepository)
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

        [HttpPost]
        public void AddPlayer([FromBody] Player data)
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
