using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
   public class UserMapper : BaseMapper<User>
    {
        public UserMapper()
        {
            ToTable("TB_USER");
            Map(entity => entity.Name).ToColumn("NM_USER");
            Map(entity => entity.Email).ToColumn("DS_EMAIL");
            Map(entity => entity.Password).ToColumn("DS_PASSWORD");
            Map(entity => entity.Birthday).ToColumn("DS_BIRTHDAY"); 
            Map(entity => entity.Gender.Id).ToColumn("ID_GENDER"); 
            Map(entity => entity.Cover.Id).ToColumn("ID_COVER"); 
            Map(entity => entity.Avatar.Id).ToColumn("ID_AVATAR"); 
        }

    }
}
