namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosRefatorados
{
    public interface PrecificadorDeAnimal
    {
        decimal CalcularValor(Cavalo cavalo);
        bool SeEnquadraPara(Cavalo cavalo);
    }
}