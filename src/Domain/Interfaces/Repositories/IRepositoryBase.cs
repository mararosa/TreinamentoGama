using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity//criado uma base so para o que vai para o repositorio
    {
    }
}
