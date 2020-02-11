using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class GalleryApplication : ApplicationBase<Gallery>, IGalleryApplication
    {
        private readonly IGalleryService _service;

        public GalleryApplication(IGalleryService service) : base(service)
        {
            _service = service;
        }
    }
}
