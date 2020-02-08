using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    class UserRepository : RepositoryBase<User>, IUserRepository  //implementando todo o repository usuario em repository base usuario
    {
        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
