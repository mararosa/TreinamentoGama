using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity//essa clase sera aimplementacao do meu contrato. 
    {
        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Guet(Expression<Func<bool, TEntity>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
