using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class UserApplication : ApplicationBase<User>, IUserApplication
    {
        private readonly IUserService _service;

        public UserApplication(IUserService service) :base(service)
        {
            _service = service;
        }
    }
}
