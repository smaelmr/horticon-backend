using Core.Contracts.Repositories;
using Core.Entities.WaterChanges;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class WaterChangeRepository : BaseRepository<WaterChange>, IWaterChangeRepository
    {
        public WaterChangeRepository(MySqlContext context) 
            : base(context) 
        {
            
        }
}
}
