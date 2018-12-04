using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Services;
using Core.Entities.Plantations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantingController : ControllerBase
    {
        private IPlantingService service;

        public PlantingController(IPlantingService service)
        {
            this.service = service;
        }

        // GET: api/Planting
        [HttpGet]
        public IList<Planting> Get()
        {
            var plantations = service.Get();

            return plantations;
        }

        // GET: api/Planting/5
        [HttpGet("{id}", Name = "GetPlanting")]
        public Planting Get(int id)
        {
            var planting = service.Get(id);

            return planting;
        }

        // POST: api/Planting
        [HttpPost]
        public void Post([FromBody] Planting value)
        {
            var planting = service.Post<PlantingValidator>(value);
        }

        // PUT: api/Planting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Planting value)
        {
            var planting = service.Put<PlantingValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
