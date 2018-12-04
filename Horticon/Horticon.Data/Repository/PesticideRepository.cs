using Core.Contracts.Repositories;
using Core.Entities.Pesticides;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class PesticideRepository : BaseRepository<Pesticide>, IPesticideRepository
    {
        public PesticideRepository(MySqlContext context)
            : base(context)
        {

        }
    }
}
