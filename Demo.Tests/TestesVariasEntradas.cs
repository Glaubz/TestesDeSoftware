using Xunit;

namespace Demo.Tests
{
    public class TestesVariasEntradas
    {
        [Theory(DisplayName = "Verificar Somas")]
        [Trait("Teste", "Somas")]
        [InlineData(2, 2, 4)]
        [InlineData(77, 23, 100)]
        [InlineData(22, 22, 44)]
        [InlineData(2456, 1000, 3456)]
        [InlineData(1, 2, 3)]
        public void Calculadora_Somar_VerificarSomas(double a, double b, double total)
        {
            //Arrange
            Calculadora _calculadora = new Calculadora();

            //Act
            double _resultado = _calculadora.Somar(a, b);

            //Assert
            Assert.Equal(_resultado, total);
        }
    }
}
