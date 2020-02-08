using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Repository.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public static class RegisterMappers
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new GalleryMapper());
                config.AddMap(new GenderMapper());
                config.AddMap(new InviteMapper());
                config.AddMap(new InviteStatusMapper());
                config.AddMap(new LikeMapper());
                config.AddMap(new MediaMapper());
                config.AddMap(new MediaTypeMapper());
                config.AddMap(new PostMapper());
                config.AddMap(new UserMapper());
                config.ForDommel();
            }
            );
        }
    }
}
