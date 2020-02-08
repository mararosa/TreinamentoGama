using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Guid ParentId { get; set; } //nao estou criando um new, entao eh valor do Id eh nulo.
        public string Text { get; set; }
        public List<Media> Midias { get; set; }
        public List<User> Likes { get; set; }
        public List<Post> Comments { get; set; } //so vira comentario se tiver o id do pai
        public User Author { get; set; } //post tem um autor que eh do tipo usuario
    }
}
