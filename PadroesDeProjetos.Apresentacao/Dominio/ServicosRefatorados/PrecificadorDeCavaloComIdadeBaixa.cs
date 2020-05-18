namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComIdadeBaixa : PrecificadorDeAnimal
    {
        public decimal CalcularValor(Cavalo cavalo)
        {
            return 1000;
        }

        public bool SeEnquadraPara(Cavalo cavalo)
        {
            return cavalo.EhUmAnimalNovo;
        }
    }
}
