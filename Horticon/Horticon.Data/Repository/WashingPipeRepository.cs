using Core.Contracts.Repositories;
using Core.Entities.WashingPipes;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class WashingPipeRepository : BaseRepository<WashingPipe>, IWashingPipeRepository
    {
        public WashingPipeRepository(MySqlContext context)
            : base(context)
        {

        }
    }
}
