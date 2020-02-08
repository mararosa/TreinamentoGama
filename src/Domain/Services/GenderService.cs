using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
   public  class GenderService : ServiceBase<Gender>, IGenderService //fiz u servico q tem a interface IgenderService que deriva da classe base
    {
        private readonly IGenderRepository _repository; //para o servico trabalhar precisa d eum repositorio
        public GenderService(IGenderRepository repository)
        {
            _repository = repository; //cria a propriedade e injeta um no outro
        }
    }
}
