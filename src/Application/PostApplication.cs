using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class PostApplication : ApplicationBase<Post>, IPostApplication
    {
        private readonly IPostService _service;

        public PostApplication(IPostService service) : base(service)
        {
            _service = service;
        }
    }
}
