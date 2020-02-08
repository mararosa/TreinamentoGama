using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces
{
   public interface IBase<TEntity> where TEntity : BaseEntity //isso eh para deixar generico. se trocar a classe(baseentity), troca para todos.
    {//clausulas que todas as entidades devem obedecer

       IQueryable<TEntity> Guet(Expression<Func<bool, TEntity>> predicate); //trabalhando com uma clausa para usar o lambda //nome do metodo e o retorno dele. Quando fizer o metodo get tem que retornar uma colecao do tipo Iqueryable BaseEntity
        TEntity Get(Guid id); //sobrecarga do metodo get Retorna um so, entao nao eh lista
        bool Insert(TEntity entity); //precisa importar um dado entao retorna um baseentity. Para esse metodo executar precisa passar(herdar) um objeto que atenda o BaseEntity
        bool Update(TEntity entity); //() esta a assinatura do metodo. Isso eh uma clausula, quem implementar esse metodo precisa ter os metodos
        bool Delete(Guid Id); //boolen pq pode ou nao achar um dado. Passo o metodo, ex, uma galeria, se tiver algo la, devolve true
    }
}
