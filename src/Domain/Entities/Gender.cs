using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Gender : BaseEntity
    {
        public string Description { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentNullException("Description nao foi preenchido");
        }
    }
}
