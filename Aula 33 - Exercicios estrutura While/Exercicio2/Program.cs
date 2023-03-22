// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
// cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

using System;
using System.Globalization;

namespace Course{
    class program{
        static void Main(string[] args){

            Console.Write("Digite seu primeiro numero por favor: ");
            int numberOne = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            Console.Write("Digite seu segundo numero por favor: ");
            int numberTwo = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            while (numberOne != 0 && numberTwo != 0){
                if (numberOne > 0 && numberTwo > 0){
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if(numberOne < 0 && numberTwo > 0){
                    Console.WriteLine("Segunda Quadrante");
                }
                else if(numberOne < 0 && numberTwo < 0){
                    Console.WriteLine("Terceiro Quadrante");
                }
                else {
                    Console.WriteLine("Quarto Quadrante");
                }
                Console.Write("Digite novamente o numero para X: ");
                numberOne = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
                Console.Write("Digite novamente um numero para y: ");
                numberTwo = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            }
        }
    }
}