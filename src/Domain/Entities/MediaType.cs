﻿using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class MediaType : BaseEntity
    {
        public string Description { get; set; }
        public string Extensions { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentNullException("'Description' não foi preenchido");

            if (string.IsNullOrWhiteSpace(Extensions)) throw new ArgumentNullException("'Extensions' não foi preenchido");
        }
    }
}
