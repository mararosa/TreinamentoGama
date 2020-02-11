using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Repositories;

namespace Test
{
    [TestClass] //atributo testclass
    public class GenderTeste
    {
        private readonly IGenderService _service;
        public GenderTeste()
        {
            var repository = new GenderRepository();

            var _service = new GenderService(repository); //precia de um repositorio que atenda o genderService
        }
        [TestMethod]
        public void GenderValidation()
        {
            var gender = new Gender();

            _service.Insert(gender);
        }
    }
}
