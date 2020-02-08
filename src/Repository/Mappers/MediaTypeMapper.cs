using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
   public class MediaTypeMapper : BaseMapper<MediaType>
    {
        public MediaTypeMapper()
        {
            ToTable("TB_MEDIA_TYPE");
            Map(entity => entity.Description).ToColumn("DS_MEDIA_TYPE");
            Map(entity => entity.Extensions).ToColumn("DS_EXTENSIONS");

        }
    }
}
