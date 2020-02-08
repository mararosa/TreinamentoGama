using Gama.RedeSocial.Domain.Interfaces.Services;
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

            var service = newGenderService(repository); //precia de um repositorio que atenda o genderService
        }
        [TestMethod]
        public void GenderValidation()
        {

        }
    }
}
