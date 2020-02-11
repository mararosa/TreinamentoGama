using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class MediaTypeApplication : ApplicationBase<MediaType>, IMediaTypeApplication
    {
        private readonly IMediaTypeService _service;

        public MediaTypeApplication(IMediaTypeService service) : base(service)
        {
            _service = service;
        }
    }
}
