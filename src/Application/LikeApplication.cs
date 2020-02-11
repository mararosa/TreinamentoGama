using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class LikeApplication : ApplicationBase<Like>, ILikeApplication
    {
        private readonly ILikeService _service;

        public LikeApplication(ILikeService service) : base(service)
        {
            _service = service;
        }
    }
}
