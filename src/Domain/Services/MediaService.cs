using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
   public class MediaService : ServiceBase<Media>, IMediaService
    {
        private readonly IMediaRepository _repository;

        public MediaService(IMediaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
