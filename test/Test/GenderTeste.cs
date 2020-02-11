using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using Repository.Repositories;
using System;

namespace Test
{
    [TestClass] //atributo testclass
    public class GenderTeste
    {
        private readonly IGenderService _service;
        public GenderTeste()
        {
            RegisterMappers.Register();

            var repository = new GenderRepository();

            _service = new GenderService(repository); //precia de um repositorio que atenda o genderService
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTest()
        {
            var gender = new Gender();

            _service.Insert(gender);

            //nada mais executa depois de um estouro de exceção 
        }

        [TestMethod]
        public void IntegratedTest()
        {
            var gender = new Gender()
            {
                Description = "Indefinido"
            };

            _service.Insert(gender);
        }
    }
}
