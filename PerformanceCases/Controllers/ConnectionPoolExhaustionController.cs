using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PerformanceCases.Controllers
{
    //SqlServer'a maxconnectionpoolsize = 1 de. Yük testi yap. Dump'ını al. Sql'e gidemiyoruz dedikleri zaman neden gidemediklerini gör. 
    //Prometheus exporter'ını koy ve Prometheus operator'ından topla.
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionPoolExhaustionController : ControllerBase
    {
        // GET: api/ConnectionPoolExhaustion
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ConnectionPoolExhaustion/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ConnectionPoolExhaustion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ConnectionPoolExhaustion/5
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
