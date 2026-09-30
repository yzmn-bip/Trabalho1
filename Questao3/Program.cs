namespace Questao3
{
    public class Program
    {
        public static RelatorioReservaDto Mapear(Reserva reserva)
        {
            decimal valorTotal = reserva.QuantidadeDiarias * reserva.ValorDiaria;

            return new RelatorioReservaDto(
                reserva.NomeHospede,
                reserva.NumeroQuarto,
                reserva.QuantidadeDiarias,
                valorTotal,
                "Reserva confirmada"
            );
        }

        public static void ExibirRelatorio(RelatorioReservaDto relatorio)
        {
            Console.WriteLine("Nome do hóspede: " + relatorio.NomeHospede);
            Console.WriteLine("Número do quarto: " + relatorio.NumeroQuarto);
            Console.WriteLine("Quantidade de diárias: " + relatorio.QuantidadeDiarias);
            Console.WriteLine("Valor total: " + relatorio.ValorTotal);
            Console.WriteLine("Situação: " + relatorio.Situacao);
        }

        public static void Main(string[] args)
        {
            Reserva reserva = new Reserva
            {
                Id = 1,
                NomeHospede = "Maria",
                NumeroQuarto = 10,
                QuantidadeDiarias = 3,
                ValorDiaria = 200,
                StatusInterno = "Ativa",
                ObservacaoInterna = "Sem observações"
            };

            RelatorioReservaDto relatorio = Mapear(reserva);
            ExibirRelatorio(relatorio);
        }
    }
}
