using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.WashingPipes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class WashingPipeService : BaseService<WashingPipe>, IWashingPipeService
    {

        public WashingPipeService(IWashingPipeRepository repository)
            : base(repository)
        {

        }
    }
}
