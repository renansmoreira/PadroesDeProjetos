using PadroesDeProjetos.Apresentacao.Dominio;

namespace PadroesDeProjetos.Apresentacao
{
    public class ValorDoAnimal
    {
        public ValorDoAnimal(Cavalo cavalo)
        {
            Cavalo = cavalo;
            Valor = 0;
        }

        public Cavalo Cavalo { get; }
        public decimal Valor { get; private set; }

        internal void Adicionar(decimal valorAdicional)
        {
            Valor += valorAdicional;
        }
    }
}
