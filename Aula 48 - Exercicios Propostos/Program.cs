// faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reias. informar quantos
// reais a pessoa vai pagar pelos dolares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma
// classe ConversorDeMoeda estatica para ser responsavel pelos calculos.
using System;
using System.Globalization;


namespace Course{
    class Program{
        static void Main(string[] args){

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            ConversorDeMoeda.compraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.CalculoDolar()); 
            
        }
    }
}