// exemplo de um programa feito com orientação a objeto
using System;
using System.Globalization; // utilização do cultureInfo.InvarianteCulture para troca do ponto para virgula.

namespace Course{
    class Program{
        static void Main(string[] args){

            Triangulo x;// uma variavel X com o tipo triangulo, que foi um atributo criado no outro arquivo.
            Triangulo y;// uma variavel Y com o tipo triangulo, que foi um atributo criado no outro arquivo. 

            x = new Triangulo(); // é necessario que sempre quando você for criar um variavel que seja um tipo de uma classe, que ela seja sempre instanciada.
            y = new Triangulo();

            Console.Write("entre com as medidas do triangulo X: "); // leitura da entrada dos dados dos 3 lados do triangulo X
            x.A = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);// basicamente para definirmo sum determinado valor que o usuario digitar em um atributo
            x.B = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);// que foi definido lá na criação do trianguilo.. basta colocarmos um ponto e a partir
            x.C = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);// definirmos para qual atributo a resposta do usuario será adicionada.

            Console.Write("entre com as medidas do triangulo Y: "); // leitura da entrada dos dados dos 3 lados do triangulo Y
            y.A = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            
            double areaX = x.Area();// calculo da area do triangulo x... aquele return que definimos na função anterior, vai retorar aquele valor aqui, e para chamarmos aquela 
                                    // função é necessario que tenha uma instanciação ou seja.. o nome da função com abre e fecha parenteses na frente.
            
            double areaY = y.Area(); // calculo da area do triangulo y

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