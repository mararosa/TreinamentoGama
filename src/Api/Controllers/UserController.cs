using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _app; //vai puxar na API a aplicacao
                                                
        public UserController(IUserApplication app) //controller precisa injetar o controller
        {
            _app = app;
        }

        public User Get(Guid id)
        {
            return _app.Get(id);
        }
    }
}