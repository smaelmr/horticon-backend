using Core.Contracts.Repositories;
using Core.Entities.WaterControls;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class WaterControlRepository : BaseRepository<WaterControl>, IWaterControlRepository
    {
        public WaterControlRepository(MySqlContext context)
            : base(context)
        {

        }
    }
}
