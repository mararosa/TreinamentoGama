
using Dommel;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity//essa clase sera aimplementacao do meu contrato. 
    {
        public bool Delete(Guid id)
        {
            using (var connection = SqlConnectionFactory.Create()) //using eh um try-finally
            {
                return connection.Delete(id);
            }
        }

        public TEntity Get(Guid Id)
        {

            using (var connection = SqlConnectionFactory.Create())
            {
                return connection.Get<TEntity>(Id);
            }

        }

        public IEnumerable<TEntity> Guet(Expression<Func<TEntity, bool>> predicate)
        {

            using (var connection = SqlConnectionFactory.Create())
            {
                return connection.Select(predicate);
            }
        }

        public Guid Insert(TEntity entity)
        {
            using (var connection = SqlConnectionFactory.Create())
            {
               connection.Insert(entity);

                return entity.Id;
            }
        }

        public bool Update(TEntity entity)
        {
            using (var connection = SqlConnectionFactory.Create())
            {
               return  connection.Update(entity);
            }
        }
    }
}
