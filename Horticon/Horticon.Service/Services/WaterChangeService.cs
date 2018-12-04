using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.WaterChanges;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class WaterChangeService : BaseService<WaterChange>, IWaterChangeService
    {

        public WaterChangeService(IWaterChangeRepository repository)
            : base(repository)
        {

        }
    }
}
