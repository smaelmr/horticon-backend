using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.WaterControls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class WaterControlService : BaseService<WaterControl>, IWaterControlService
    {

        public WaterControlService(IWaterControlRepository repository)
            : base(repository)
        {

        }
    }
}
