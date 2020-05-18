using System;
using System.Collections.Generic;
using PadroesDeProjetos.Apresentacao.Dominio;
using PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados;

namespace PadroesDeProjetos.Apresentacao
{
    class Program
    {
        static void Main()
        {
            var precificadores = new List<PrecificadorDeAnimal>
            {
                new PrecificadorDeCavaloComCoberturasAbaixoDaMedia(),
                new PrecificadorDeCavaloComCoberturasAcimaDaMedia(),
                new PrecificadorDeCavaloComCoberturasNaMedia(),
                new PrecificadorDeCavaloComIdadeAvancada(),
                new PrecificadorDeCavaloComIdadeBaixa(),
                new PrecificadorDeCavaloComPelagemRara()
            };
            var precificador = new PrecificadorComEstrategia(precificadores);

            var cavalo = new Cavalo("Bucéfalo", 8, ColoracaoDaPelagem.Preto);
            cavalo.InformarQuantidadeDeCoberturasPorAno(300);

            var valorDoAnimal = precificador.Precificar(cavalo);

            Console.WriteLine("Valor do {0}: {1}",
                cavalo.Nome, valorDoAnimal.Valor);
        }
    }
}
