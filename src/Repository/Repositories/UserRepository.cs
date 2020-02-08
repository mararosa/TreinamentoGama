using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    class UserRepository : RepositoryBase<User>, IUserRepository  //implementando todo o repository usuario em repository base usuario
    {
        public IEnumerable<User> GetByName(string firstName)
        {
            var sql = "SELECT FROM TB_USER WHERE NM_USER = @name";

            var parameters = new { name = firstName}; //objeto anonimo nao tem tipo

          return Execute<User>(sql, parameters); //vai retornar uma (Ienumerable) lista de usuarios
        }
    }
}
