using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class InviteStatus : BaseEntity
    {
        public string Description { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentNullException("'Description' não foi preenchido");
        }
    }
}