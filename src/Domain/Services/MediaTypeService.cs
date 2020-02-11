using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
    public class MediaTypeService : ServiceBase<MediaType>, IMediaTypeService
    {
        private readonly IMediaTypeRepository _repository;

        public MediaTypeService(IMediaTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
