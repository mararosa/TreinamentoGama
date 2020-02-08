﻿using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
   public interface IServiceBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}
