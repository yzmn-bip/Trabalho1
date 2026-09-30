namespace Questao2
{
    public class Equipamento
    {
        public int Id { get; set; }

        [Exibir]
        public string Nome { get; set; }

        [Exibir]
        public string Fabricante { get; set; }

        public string NumeroSerie { get; set; }

        [Exibir]
        public decimal Valor { get; set; }

        [Exibir]
        public string Localizacao { get; set; }
    }
}
