using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PerformanceCases.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemoryLeakController : ControllerBase
    {
        // GET: api/MemoryLeak
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MemoryLeak/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MemoryLeak
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MemoryLeak/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
