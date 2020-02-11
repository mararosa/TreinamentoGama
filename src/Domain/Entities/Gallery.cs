using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public string Name { get; set; }
        public List<Media> Medias { get; set; }
        public User Author { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentNullException("O nome deve ser preenchido");

            ValidarListas<Media>(Medias);
            foreach (var media in Medias)
            {
                media.Validate();
            }

            Author.Validate();
        }
    }
}
