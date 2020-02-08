using Dapper.FluentMap.Dommel.Mapping;
using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class BaseMapper<TEntity> : DommelEntityMap<TEntity> where TEntity : BaseEntity //classe generica. Ex, usermap herda de baseMapper
    {

        public BaseMapper() //Toda vez que for mapear as entidades usara o basemapper
            {

            Map(entity => entity.Id).ToColumn("ID").IsKey(); //quando for para tabela de dados as colunas serao criadas dessa maneira
            Map(e => e.DateCreated).ToColumn("DT_CREATED");
            Map(e => e.DateUpdated).ToColumn("DT_UPDATED");
            Map(e => e.Active).ToColumn("ST_ACTIVE");

            }

    }
}
