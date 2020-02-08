using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
