using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PerformanceCases.Controllers
{

    //Dosyayı alıp sadece grpc üzerinden serialie / deserizlize yapılacak. Yük testi yap. Dump'ı al, dump'tan neler çıkacak. Protobuff üzerinden yapılacak. bu işlemin sonunda hangi thread i/o bound anlaşılacak.
    //Protobuff ile serialize / deserialize et.
    //Çok fazla serialize varsa CPU bound bir işlem.
    //Yük testi öncesi ve sırasında dump al. karşılaştır.
    //https://www.udemy.com/course/grpc-csharp/

    [Route("api/[controller]")]
    [ApiController]
    public class HighCPUController : ControllerBase
    {
        // GET: api/HighCPU
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HighCPU/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HighCPU
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/HighCPU/5
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
