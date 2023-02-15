using Demo.Tests.Fixtures;
using Xunit;

namespace Demo.Tests
{
    //Declarar coleção acima da classe de teste para que a Fixture seja distribuída
    [Collection(nameof(NumerosParaCalculosCollection))]
    public class Testes : IClassFixture<Calculadora>
    {
        private readonly NumerosParaCalculoFixture _fixture;

        public Testes(NumerosParaCalculoFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "VerificarSoma")]
        [Trait("Teste","Soma")]
        public void Calculadora_Somar_VerificarSoma()
        {
            //Arrange
            Calculadora _calculadora = new Calculadora();
            Calculadora valoresDaFixture = _fixture.ObterNumerosFixture();

            //Act
            double _resultado = _calculadora.Somar(2,2);
            double _resultadoFixture = _calculadora.Somar(valoresDaFixture.InteiroA, valoresDaFixture.InteiroB);

            //Assert
            Assert.Equal(30, _resultadoFixture);
        }
    }
}
