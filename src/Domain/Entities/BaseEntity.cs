using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Entities
{
    public abstract class BaseEntity
    {

        public BaseEntity()
        {
            Id = Guid.NewGuid(); //devolve um novo guid

            DateCreated = DateTime.Now; //data atual se as datas forem iguais. isso quer dizer que o usuario nunca foi alterado.

            DateUpdated = DateTime.Now; //quando for atualizar o user da base, ele vem com tudo (id, data criacao e atualizacao).

            Active = true;
        }

        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }

        public abstract void Validate();


        #region MetodoTeste
        //protected void ValidarListas<TEntity>(List<TEntity> list)
        //{
        //    var result = list?.Count < 1 ? throw new ArgumentNullException("A lista esta vazia") : list;
        //}
        #endregion
    }
}
