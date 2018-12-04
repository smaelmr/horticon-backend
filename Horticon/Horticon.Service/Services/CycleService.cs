
using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.Cycles;

namespace Service.Services
{
    public class CycleService : BaseService<Cycle>, ICycleService
    {
        public CycleService(ICycleRepository repository)
            :base(repository)
        {

        }
    }
}
