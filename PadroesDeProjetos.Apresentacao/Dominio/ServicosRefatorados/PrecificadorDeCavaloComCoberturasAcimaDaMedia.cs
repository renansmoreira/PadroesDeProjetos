namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComCoberturasAcimaDaMedia
        : PrecificadorDeAnimal
    {
        public decimal CalcularValor(Cavalo cavalo)
        {
            return 5000;
        }

        public bool SeEnquadraPara(Cavalo cavalo)
        {
            return cavalo.PossuiUmaQuantidadeDeCoberturasAcimaDaMedia;
        }
    }
}
