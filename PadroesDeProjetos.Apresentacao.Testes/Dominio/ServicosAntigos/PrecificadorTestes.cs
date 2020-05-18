using PadroesDeProjetos.Apresentacao.Dominio;
using PadroesDeProjetos.Apresentacao.Dominio.ServicosAntigos;
using Xunit;

namespace PadroesDeProjetos.Apresentacao.Testes.Dominio.ServicosAntigos
{
    public class PrecificadorTestes
    {
        [Fact]
        public void Deve_precificar_um_cavalo_com_baixa_idade()
        {
            var precificador = new Precificador();
            var cavaloNovo = new Cavalo("Pé de pano", 5, ColoracaoDaPelagem.Branco);
            var valorEsperado = 2000;

            var valorDoAnimal = precificador.CalcularValor(cavaloNovo);

            Assert.Equal(valorEsperado, valorDoAnimal.Valor);
        }
    }
}
