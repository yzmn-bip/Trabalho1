using System.Reflection;

namespace Questao2
{
    public class Program
    {
        public static void ExibirDadosAberto(object objeto)
        {
            Type tipo = objeto.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                Console.WriteLine(propriedade.Name + ": " + propriedade.GetValue(objeto));
            }
        }

        public static void ExibirDadosControlado(object objeto)
        {
            Type tipo = objeto.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                ExibirAttribute atributo = propriedade.GetCustomAttribute<ExibirAttribute>();

                if (atributo != null)
                {
                    Console.WriteLine(propriedade.Name + ": " + propriedade.GetValue(objeto));
                }
            }
        }

        public static void Main(string[] args)
        {
            Equipamento equipamento = new Equipamento
            {
                Id = 1,
                Nome = "Notebook",
                Fabricante = "Dell",
                NumeroSerie = "ABC123",
                Valor = 3500,
                Localizacao = "Sala 1"
            };

            Console.WriteLine("Reflection aberta:");
            ExibirDadosAberto(equipamento);

            Console.WriteLine();
            Console.WriteLine("Reflection controlada:");
            ExibirDadosControlado(equipamento);
        }
    }
}
