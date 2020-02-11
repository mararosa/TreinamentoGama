using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class MediaApplication : ApplicationBase<Media>, IMediaApplication
    {
        private readonly IMediaService _service;

        public MediaApplication(IMediaService service) : base(service)
        {
            _service = service;
        }
    }
}
