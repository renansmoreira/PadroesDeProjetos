using System;
using System.Collections.Generic;
using System.Linq;

namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorComEstrategia
    {
        private readonly IEnumerable<PrecificadorDeAnimal> precificadores;

        public PrecificadorComEstrategia(
            IEnumerable<PrecificadorDeAnimal> precificadores)
        {
            this.precificadores = precificadores;
        }

        public ValorDoAnimal Precificar(Cavalo cavalo)
        {
            var valorDoAnimal = new ValorDoAnimal(cavalo);
            var precificadoresAplicaveis = precificadores
                .Where(precificador => precificador.SeEnquadraPara(cavalo))
                .ToList();

            foreach (var precificador in precificadoresAplicaveis) {
                var valorDefinidoPeloPrecificador =
                    precificador.CalcularValor(cavalo);
                valorDoAnimal.Adicionar(valorDefinidoPeloPrecificador);
            }

            return valorDoAnimal;
        }
    }
}
