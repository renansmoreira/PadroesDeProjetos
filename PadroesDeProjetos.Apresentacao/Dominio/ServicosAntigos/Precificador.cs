namespace PadroesDeProjetos.Apresentacao.Dominio.ServicosAntigos
{
    public class Precificador
    {
        public ValorDoAnimal CalcularValor(Cavalo cavalo)
        {
            ValorDoAnimal valorDoAnimal = new ValorDoAnimal(cavalo);

            if (cavalo.Idade <= 8)
            {
                valorDoAnimal.Adicionar(1000);
            }
            else
            {
                valorDoAnimal.Adicionar(200);
            }

            if (cavalo.QuantidadeDeCoberturasPorAno > 150)
            {
                valorDoAnimal.Adicionar(5000);
            }
            else if (cavalo.QuantidadeDeCoberturasPorAno > 125)
            {
                valorDoAnimal.Adicionar(2500);
            }
            else
            {
                valorDoAnimal.Adicionar(1000);
            }

            return valorDoAnimal;
        }
    }
}
