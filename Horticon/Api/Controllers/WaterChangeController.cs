using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Services;
using Core.Entities.WaterChanges;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterChangeController : ControllerBase
    {
        private IWaterChangeService service;

        public WaterChangeController(IWaterChangeService service)
        {
            this.service = service;
        }

        // GET: api/Planting
        [HttpGet]
        public IList<WaterChange> Get()
        {
            var waterChanges = service.Get();

            return waterChanges;
        }

        // GET: api/Planting/5
        [HttpGet("{id}", Name = "GetWaterChange")]
        public WaterChange Get(int id)
        {
            var waterChange = service.Get(id);

            return waterChange;
        }

        // POST: api/Planting
        [HttpPost]
        public void Post([FromBody] WaterChange value)
        {
            var waterChange = service.Post<WaterChangeValidator>(value);
        }

        // PUT: api/Planting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WaterChange value)
        {
            var waterChange = service.Put<WaterChangeValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
