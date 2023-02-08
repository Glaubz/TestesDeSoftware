using Xunit;

namespace Demo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Calculadora_Somar_VerificarSoma()
        {
            //Arrange
            Calculadora _calculadora = new Calculadora();

            //Act
            double _resultado = _calculadora.Somar(2,4);

            //Assert
            Assert.Equal(4, _resultado);
        }
    }
}
