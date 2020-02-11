using System;
using System.Text.RegularExpressions;

namespace Gama.RedeSocial.Domain.Entities
{
    public class User : BaseEntity //User deriva/herda da classe Baseentity. Agora ele tem a forma dele e a forma do pai
    {

        public User()
        {
            Gender = new Gender(); //vai na minha propriedade gender e instancia o gender para mim.
            Cover = new Media();
            Avatar = new Media();
        }

        public string Name { get; set; } // get, set sao metodos da propriedade
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }

        public Guid GenderId { get; set; }
        public Gender Gender { get; set; } // classes estao comecando a se relacionar na POO

        public Guid CoverId { get; set; }
        public Media Cover { get; set; }

        public Guid AvatarId { get; set; }
        public Media Avatar { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if (String.IsNullOrWhiteSpace(Email))
                throw new ArgumentNullException("'Email' não foi preenchido");

            if (!Regex.Match(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                throw new ArgumentException("'Email' é inválido");

            if (String.IsNullOrWhiteSpace(Password))
                throw new ArgumentNullException("'Password' não foi preenchido");

            if (Password.Length < 8)
                throw new ArgumentException("'Password' menor que 8 caracteres");

            if (Birthday == null)
                throw new ArgumentNullException("'Birthday' não foi preenchido");

            if (Birthday == DateTime.MinValue)
                throw new ArgumentException("'Birthday' é inválido");

            if (GenderId == Guid.Empty)
                throw new ArgumentNullException("'GenderId' não foi preenchido");

            if (CoverId == Guid.Empty)
                throw new ArgumentNullException("'CoverId' não foi preenchido");

            if (AvatarId == Guid.Empty)
                throw new ArgumentNullException("'AvatarId' não foi preenchido");
            #region MetodoTeste
            //Gender.Validate();
            //Cover.Validate();
            //Avatar.Validate(); 
            #endregion
        }
    }
}
