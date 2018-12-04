using Core.Contracts.Repositories;
using Core.Contracts.Services;
using Core.Entities.Users;

namespace Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {

        public UserService(IUserRepository repository)
            : base(repository)
        {

        }
    }
}
