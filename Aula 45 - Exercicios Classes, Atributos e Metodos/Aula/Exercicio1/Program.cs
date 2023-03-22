// Fazer um programa para ler os valores da largura e altura de um retangulo. Em seguida, mostrar na tela
// o valor de sua area, perimetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
using System;
using System.Globalization;

namespace Course{
    class program{
        static void Main(string[] args){

            Retangulo retangulo;

            retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do Retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + retangulo.Area());
            Console.WriteLine("Perimetro: " + retangulo.Perimetro());
            Console.WriteLine("Diagonal: " + retangulo.Diagonal());

        }
    }
}