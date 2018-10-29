using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Services;
using Core.Entities.Cycles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CycleController : ControllerBase
    {
        ICycleService service;

        public CycleController(ICycleService service)
        {
            this.service = service;
        }

        // GET: api/Pesticide
        [HttpGet]
        public IList<Cycle> Get()
        {
            var cycles = service.Get();

            return cycles;
        }

        // GET: api/Pesticide/5
        [HttpGet("{id}", Name = "GetCycle")]
        public Cycle Get(int id)
        {
            var cycle = service.Get(id);

            return cycle;
        }

        // POST: api/Pesticide
        [HttpPost]
        public void Post([FromBody] Cycle value)
        {
            var pesticide = service.Post<CycleValidator>(value);
        }

        // PUT: api/Pesticide/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cycle value)
        {
            var pesticide = service.Put<CycleValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
