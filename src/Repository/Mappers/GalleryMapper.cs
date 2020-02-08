using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class GalleryMapper : BaseMapper<Gallery>
    {
        public GalleryMapper()
        {
            ToTable("TB_GALLERY");
            Map(entity => entity.Author.Id).ToColumn("DS_AUTHOR");
            Map(entity => entity.Name).ToColumn("NM_GALLERY");
        }
    }
}
