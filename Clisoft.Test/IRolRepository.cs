using Clisoft.Infraestructure.Data;
using Clisoft.Infraestructure.Data.Repository.EntityFramework;
using Xunit;

namespace Clisoft.Test
{
    public class IRolRepository
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var numeroRoles = 2;
            Suma obj = new Suma();

            //Act

            var resultad = obj.sumaNumero();

            //Assertsss

            Assert.Equal(numeroRoles, resultad);
        }
    }
}
