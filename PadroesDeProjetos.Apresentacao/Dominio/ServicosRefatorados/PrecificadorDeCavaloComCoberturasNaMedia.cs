namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComCoberturasNaMedia
        : PrecificadorDeAnimal
    {
        public decimal CalcularValor(Cavalo cavalo)
        {
            return 2500;
        }

        public bool SeEnquadraPara(Cavalo cavalo)
        {
            return cavalo.PossuiUmaQuantidadeDeCoberturasNaMedia;
        }
    }
}
