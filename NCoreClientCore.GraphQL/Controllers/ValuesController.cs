using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gecko.NCore.Client;
using Gecko.NCore.Client.ObjectModel.V3.En;
using Microsoft.AspNetCore.Mvc;
using NCoreClientCore.NetStandard;
using Gecko.NCore.Client.Querying;

namespace NCoreClientCore.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEphorteContext _context;

        public ValuesController(NCoreFactory factory) 
            => _context = factory.Create();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var query = from c in _context.Query<Case>().Include(x => x.OfficerName)
                        where c.Id > 10
                        select c;
            var caseDetail = query.Take(40);

            return caseDetail.Select(c => $"{c.Title} => {c.OfficerName.FirstName} {c.OfficerName.LastName}").ToArray();
            
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
        public void Post([FromBody] string value)
        {
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
