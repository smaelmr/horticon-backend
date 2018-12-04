using Core.Contracts.Repositories;
using Core.Entities.Plantations;
using Data.Context;

namespace Data.Repository
{
    public class PlantingRepository : BaseRepository<Planting>, IPlantingRepository
    {
        public PlantingRepository(MySqlContext context) 
            : base(context) 
        {
            
        }
    }
}