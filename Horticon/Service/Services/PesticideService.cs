using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.Pesticides;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PesticideService : BaseService<Pesticide>, IPesticideService
    {

        public PesticideService(IPesticideRepository repository)
            : base(repository)
        {

        }
    }
}
