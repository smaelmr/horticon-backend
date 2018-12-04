using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.Plantations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PlantingService : BaseService<Planting>, IPlantingService
    {
        public PlantingService(IPlantingRepository repository)
            : base(repository)
        {

        }
    }
}
