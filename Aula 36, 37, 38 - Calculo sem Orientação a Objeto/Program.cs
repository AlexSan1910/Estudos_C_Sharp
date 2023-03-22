// exemplo de um programa feito sem orientação a objeto
using System;
using System.Globalization; // utilização do cultureInfo.InvarianteCulture para troca do ponto para virgula.

namespace Course{
    class Program{
        static void Main(string[] args){

            double xA, xB, xC; // lado A do triangulo X, lado B do triangulo X e o lado C do triangulo X.
            double yA, yB, yC; // lado A do triangulo Y, lado B do triangulo Y e o lado C do triangulo Y.

            Console.Write("entre com as medidas do triangulo X: "); // leitura da entrada dos dados dos 3 lados do triangulo X
            xA = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.Write("entre com as medidas do triangulo Y: "); // leitura da entrada dos dados dos 3 lados do triangulo Y
            yA = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            //calculos Area trinagulo X
            double pX = (xA + xB + xC) /  2.0;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC)); // calculo da area do triangulo x

            //calculos Area trinagulo X
            double pY = (yA + yB + yC) /  2.0;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC)); // calculo da area do triangulo y

            Console.WriteLine("A area de X é igual a: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A area de Y é igual a: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY){
                Console.WriteLine("A area maior é do triangulo X");
            }else{
                Console.WriteLine("A area maior é do triangulo Y");
            }
        }
    }
}