namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public class PrecificadorDeCavaloComPelagemRara : PrecificadorDeAnimal
    {
        public decimal CalcularValor(Cavalo cavalo)
        {
            return 10000;
        }

        public bool SeEnquadraPara(Cavalo cavalo)
        {
            return cavalo.PossuiPelagemRara;
        }
    }
}
