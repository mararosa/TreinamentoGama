using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IInviteService : IServiceBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
        //IEnumerable<Invite> GetFriends(Guid userId);
    }
}
