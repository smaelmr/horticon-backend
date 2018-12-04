using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Services;
using Core.Entities.WashingPipes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WashingPipeController : ControllerBase
    {
        private IWashingPipeService service;

        public WashingPipeController(IWashingPipeService service)
        {
            this.service = service;
        }

        // GET: api/Planting
        [HttpGet]
        public IList<WashingPipe> Get()
        {
            var washingPipes = service.Get();

            return washingPipes;
        }

        // GET: api/Planting/5
        [HttpGet("{id}", Name = "GetWashingPipe")]
        public WashingPipe Get(int id)
        {
            var washingPipe = service.Get(id);

            return washingPipe;
        }

        // POST: api/Planting
        [HttpPost]
        public void Post([FromBody] WashingPipe value)
        {
            var washingPipe = service.Post<WashingPipeValidator>(value);
        }

        // PUT: api/Planting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WashingPipe value)
        {
            var washingPipe = service.Put<WashingPipeValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
