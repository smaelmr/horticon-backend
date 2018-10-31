using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Commands;
using Core.Contracts.Services;
using Core.Entities.Pesticides;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Validators;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PesticideController : ControllerBase
    {
        IPesticideService service;

        public PesticideController(IPesticideService service)
        {
            this.service = service;
        }

        // GET: api/Pesticide
        [HttpGet]
        public IList<Pesticide> Get()
        {
            var pesticides = service.Get();

            return pesticides;
        }

        // GET: api/Pesticide/5
        [HttpGet("{id}", Name = "GetPesticide")]
        public Pesticide Get(int id)
        {
            var pesticide = service.Get(id);

            return pesticide;
        }

        // POST: api/Pesticide
        [HttpPost]
        public void Post([FromBody] PesticidePostCommand value)
        {
            var pesticide = service.Post<PesticideValidator>(value);
        }

        // PUT: api/Pesticide/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pesticide value)
        {
            var pesticide = service.Put<PesticideValidator>(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
