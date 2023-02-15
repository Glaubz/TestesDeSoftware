using System;
using Xunit;

namespace Demo.Tests.Fixtures
{
    //Coleção de Fixtures, casos de testes
    [CollectionDefinition(nameof(NumerosParaCalculosCollection))]
    public class NumerosParaCalculosCollection : ICollectionFixture<Calculadora>
    {
    }

    public class NumerosParaCalculoFixture : IDisposable
    {
        /* Criado Método para retornar números para que seja realizado soma */
        public Calculadora ObterNumerosFixture()
        {
            Calculadora Numeros = new Calculadora
            {
                InteiroA = 20,
                InteiroB= 10,
            };

            return Numeros;
        }

        //Implementar o IDisposable porque o método é um método reaproveitável
        public void Dispose()
        {
        }
    }
}
