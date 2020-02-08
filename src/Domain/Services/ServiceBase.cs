using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepositoryBase<TEntity> _repository; //propriedade privada, somente leitura. Que espera o IRepository . Toda classe que atender essa interface ira funcionar.
        public bool Delete(Guid Id)
        {
            if (Id == new Guid()) throw new ArgumentNullException("O Id deve ser preenchido");

            return _repository.Delete(Id);
        }

        public TEntity Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Get(predicate); //so repassando
        }

        public Guid Insert(TEntity entity)
        {
            entity.Validate();

            return _repository.Insert(entity); //nao retorna nada, se acontecer um erro ele anca um throw
        }

        public bool Update(TEntity entity)
        {
            entity.Validate();

            return _repository.Update(entity);
        }
    }
}
