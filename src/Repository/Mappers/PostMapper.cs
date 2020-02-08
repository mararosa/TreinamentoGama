using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class PostMapper : BaseMapper<Post>
    {
        public PostMapper()
        {
            ToTable("TB_POST");
            Map(entity => entity.Text).ToColumn("DS_TEXT");
          
        }
    }
}
