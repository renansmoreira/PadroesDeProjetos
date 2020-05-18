using PadroesDeProjetos.Apresentacao.Dominio;
using PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados;
using Xunit;

namespace PadroesDeProjetos.Apresentacao.Testes.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComIdadeBaixaTestes
    {
        [Fact]
        public void Deve_precificar_um_cavalo()
        {
            var precificador = new PrecificadorDeCavaloComIdadeBaixa();
            var cavaloNovo = new Cavalo("Bala no alvo", 2, ColoracaoDaPelagem.Azulado);
            var valorEsperado = 1000;

            var valorDoAnimal = precificador.CalcularValor(cavaloNovo);

            Assert.Equal(valorEsperado, valorDoAnimal);
        }
    }
}
