using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PerformanceCases.Controllers
{
    //100 milyonluk pwd listesi. Bu liste container'ın içind eolsun. https://github.com/danielmiessler/SecLists/blob/master/Passwords/Common-Credentials/10-million-password-list-top-1000000.txt
    //Bu listeyi oku, random username ler ver, her request geldiğinde, her kullanıcı için username password u memory de tut. Tüm kullanıcı/pwd leri memory ye koy.
    [Route("api/[controller]")]
    [ApiController]
    public class HighMemUsageController : ControllerBase
    {
        // GET: api/HighMemUsage
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HighMemUsage/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HighMemUsage
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/HighMemUsage/5
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
