using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class GenderApplication : ApplicationBase<Gender>, IGenderApplication
    {
        private readonly IGenderService _service;

        public GenderApplication(IGenderService service) : base(service)
        {
            _service = service;
        }
    }
}
