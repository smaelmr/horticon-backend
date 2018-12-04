using Core.Contracts.Repositories;
using Core.Entities.Users;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MySqlContext context)
            : base(context)
        {

        }
    }
}
