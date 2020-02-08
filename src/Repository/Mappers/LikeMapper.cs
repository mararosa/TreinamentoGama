using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class LikeMapper : BaseMapper<Like>
    {
        public LikeMapper()
        {
            ToTable("TB_LIKES");
            Map(entity => entity.User.Id).ToColumn("ID_USER");
            Map(entity => entity.Post.Id).ToColumn("ID_POST");
        }
    }
}
