using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            Id = new Guid(); //crio um construtor no pai para quando eu criar um id ele instanciar
            DateCreated = DateTime.Now; //data atual se as datas forem iguais. isso quer dizer que o usuario nunca foi alterado.
            DateUpdated = DateTime.Now; //quando for atualizar o user da base, ele vem com tudo (id, data criacao e atualizacao).

        }

        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}
