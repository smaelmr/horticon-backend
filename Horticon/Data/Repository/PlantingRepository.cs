using Core.Contracts.Repositories;
using Core.Entities.Plantations;
using Data.Context;

namespace Data.Repository
{
    public class PlantingRepository : BaseRepository<Planting>, IPlantingRepository
    {
        private MySqlContext context;

        public PlantingRepository(MySqlContext context) 
            : base(context) 
        {
            this.context = context;
        }
    }
}