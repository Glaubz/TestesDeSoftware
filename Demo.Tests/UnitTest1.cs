using Xunit;

namespace Demo.Tests
{
    public class NumerosParaCalculo 
    {
        public NumerosParaCalculo() { }

        public NumerosParaCalculo(int intA, int intB) 
        { 
            InteiroA = intA;
            InteiroB = intB;
        }

        public int InteiroA { get; set; }
        public int InteiroB { get; set; }
        public decimal DecimalA { get; set; }
        public decimal DecimalB { get; set; }
    }

    public class UnitTest1
    {
        public NumerosParaCalculo NumerosParaCalculo()
        {
            var numeros = new NumerosParaCalculo(
                intA: 2,
                intB: 2);

            return numeros;
        }

        [Fact(DisplayName = "VerificarSoma")]
        [Trait("Teste","Soma")]
        public void Calculadora_Somar_VerificarSoma()
        {
            //Arrange
            Calculadora _calculadora = new Calculadora();

            //Act
            double _resultado = _calculadora.Somar(2,2);

            //Assert
            Assert.Equal(4, _resultado);
        }

        [Theory(DisplayName = "Verificar Somas")]
        [Trait("Teste","Somas")]
        [InlineData(2,2,4)]
        [InlineData(77,23,100)]
        [InlineData(22,22,44)]
        [InlineData(2456,1000,3456)]
        [InlineData(1,2,3)]
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
