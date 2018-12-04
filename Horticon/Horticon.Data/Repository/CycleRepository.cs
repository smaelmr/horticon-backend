using Core.Contracts.Repositories;
using Core.Entities.Cycles;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CycleRepository : BaseRepository<Cycle>, ICycleRepository
    {
        public CycleRepository(MySqlContext context)
            : base(context)
        {

        }
    }
}
