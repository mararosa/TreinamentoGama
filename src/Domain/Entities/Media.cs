﻿using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Media : BaseEntity
    {

        public Media()
        {
            MediaType = new MediaType();
        } //construtor para nao dar erro. Pq quando da uma nova midia ela nao tem tipo e da para acessar. O construtor "libera" o acesso.

        public Guid MediaTypeId { get; set; }
        public MediaType MediaType { get; set; } //para saber se eh foto ou video acesssa aqui

        public string Path { get; set; }

        public override void Validate()
        {
            if (MediaTypeId == Guid.Empty) throw new ArgumentNullException("'MidiaTypeId' não foi preenchido");

            if (string.IsNullOrWhiteSpace(Path)) throw new ArgumentNullException("'Path' não foi preenchido");
        }

        #region MetodoTeste
        //public override void Validate()
        //{
        //    if (string.IsNullOrWhiteSpace(Path)) throw new ArgumentNullException("Path nao pode ser vazio");

        //    MediaType.Validate();
        //} 
        #endregion
    }
}
