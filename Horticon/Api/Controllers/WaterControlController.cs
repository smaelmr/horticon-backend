using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Services;
using Core.Entities.WaterControls;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterControlController : ControllerBase
    {
        private IWaterControlService service;

        public WaterControlController(IWaterControlService service)
        {
            this.service = service;
        }

        // GET: api/Planting
        [HttpGet]
        public IList<WaterControl> Get()
        {
            var waterControls = service.Get();

            return waterControls;
        }

        // GET: api/Planting/5
        [HttpGet("{id}", Name = "GetWaterControl")]
        public WaterControl Get(int id)
        {
            var waterControl = service.Get(id);

            return waterControl;
        }

        // POST: api/Planting
        [HttpPost]
        public void Post([FromBody] WaterControl value)
        {
            var waterControl = service.Post<WaterControlValidator>(value);
        }

        // PUT: api/Planting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WaterControl value)
        {
            var waterControl = service.Put<WaterControlValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
