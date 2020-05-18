using System;
namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComIdadeAvancada : PrecificadorDeAnimal
    {
        public decimal CalcularValor(Cavalo cavalo)
        {
            return 200;
        }

        public bool SeEnquadraPara(Cavalo cavalo)
        {
            return !cavalo.EhUmAnimalNovo;
        }
    }
}
