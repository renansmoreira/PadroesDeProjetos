namespace PadroesDeProjetos.Apresentacao.Dominio
{
    public class Cavalo
    {
        public Cavalo(string nome, int idade,
            ColoracaoDaPelagem coloracaoDaPelagem)
        {
            Nome = nome;
            Idade = idade;
            PossuiPelagemRara =
                coloracaoDaPelagem == ColoracaoDaPelagem.Azulado;
        }

        public string Nome { get; }
        public int Idade { get; }
        public bool PossuiPelagemRara { get; }
        public int QuantidadeDeCoberturasPorAno { get; private set; }

        public bool EhUmAnimalNovo { get => Idade <= 8; }
        public bool PossuiUmaQuantidadeDeCoberturasAcimaDaMedia { get => QuantidadeDeCoberturasPorAno > 150; }
        public bool PossuiUmaQuantidadeDeCoberturasNaMedia { get =>
                QuantidadeDeCoberturasPorAno > 125 && QuantidadeDeCoberturasPorAno <= 150; }
        public bool PossuiUmaQuantidadeDeCoberturasAbaixoDaMedia { get => QuantidadeDeCoberturasPorAno < 125; }

        public void InformarQuantidadeDeCoberturasPorAno(int quantidade)
        {
            QuantidadeDeCoberturasPorAno = quantidade;
        }
    }
}
