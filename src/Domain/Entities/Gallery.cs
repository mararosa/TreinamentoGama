using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
   public class Gallery
    {
        public string Name { get; set; }
        public List<Media> Medias { get; set; }
        public User Author { get; set; }
    }
}
