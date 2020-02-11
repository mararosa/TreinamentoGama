using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class User : BaseEntity //User deriva/herda da classe Baseentity. Agora ele tem a forma dele e a forma do pai
    {

        public User()
        {
            Gender = new Gender(); //vai na minha propriedade gender e instancia o gender para mim.
        }

        public string Name { get; set; } // get, set sao metodos da propriedade
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; } // classes estao comecando a se relacionar na POO
        public Media Cover { get; set; } 
        public Media Avatar { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentNullException("Preenche o nome");

            if (string.IsNullOrWhiteSpace(Email)) throw new ArgumentNullException("Preencha o email");

            if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentNullException("Preencha a senha");

            if (Birthday == null) throw new ArgumentNullException("Data de nascimento requerida");

            Gender.Validate();
            Cover.Validate();
            Avatar.Validate();
        }


    }
}
