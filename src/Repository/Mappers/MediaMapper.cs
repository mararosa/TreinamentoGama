using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class MediaMapper : BaseMapper<Media>
    {
        public MediaMapper()
        {
            ToTable("TB_MEDIA");
            Map(entity => entity.MediaType.Id).ToColumn("Id_MEDIA_TYPE");
            Map(entity => entity.Path).ToColumn("DS_PATH");
        }
    }
}
