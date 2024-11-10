using System;

namespace ConversaoMoeda
{
    
    public class ConversorDeMoeda
    {
        
        public double CotacaoDolar { get; set; }
        public double ValorEmDolares { get; set; }

        public ConversorDeMoeda(double cotacaoDolar, double valorEmDolares)
        {
            CotacaoDolar = cotacaoDolar;
            ValorEmDolares = valorEmDolares;
        }

        
        public double ConverterDolarParaReal()
        {
            
            double valorEmReais = ValorEmDolares * CotacaoDolar;
            double valorComIOF = valorEmReais * 1.06; 
            return valorComIOF;
        }
    }

    
    class Programa
    {
        public void Executar()
        {
            try
            {
                
                Console.Write("Digite a cotação do dólar: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double cotacaoDolar = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.Write("Digite o valor em dólares a ser comprado: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double valorEmDolares = double.Parse(Console.ReadLine());
                Console.ResetColor();

                
                ConversorDeMoeda conversor = new ConversorDeMoeda(cotacaoDolar, valorEmDolares);

                
                double valorFinal = conversor.ConverterDolarParaReal();

              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O valor a ser pago em reais, com IOF de 6%, será: R${valorFinal:F}");
                Console.ResetColor(); 
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, insira um valor numérico válido.");
                Console.ResetColor();
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.Executar();
        }
    }
}
