using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User> //esse contrata tem td que o repository base tem + o que ele tem.
    {
        User GetByName(string name); //interface que vai pegar um get by name.
    }
}
