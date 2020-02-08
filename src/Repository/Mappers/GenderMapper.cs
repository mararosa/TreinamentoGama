using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class GenderMapper : BaseMapper<Gender> //usa o base pq ja fizemos uma classe base q serve para odas as outras
    {

        public GenderMapper()
        {
            ToTable("TB_GENDER");
            Map(entity => entity.Description).ToColumn("DS_GENDER");
        }

    }
}
